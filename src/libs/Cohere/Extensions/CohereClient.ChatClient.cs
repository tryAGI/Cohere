using System.Runtime.CompilerServices;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Cohere;

public partial class CohereClient : Meai.IChatClient
{
    private Meai.ChatClientMetadata? _chatMetadata;

    object? Meai.IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.ChatClientMetadata) ? (_chatMetadata ??= new(nameof(CohereClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<Meai.ChatResponse> Meai.IChatClient.GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var request = CreateChatRequest(messages, options);
        request.Stream = false;

        var response = await V2.Chat2Async(request, cancellationToken: cancellationToken).ConfigureAwait(false);
        var chatResponse = response.Value1 ?? throw new InvalidOperationException("Expected a non-streaming response.");

        return CreateChatResponse(chatResponse, options?.ModelId);
    }

    async IAsyncEnumerable<Meai.ChatResponseUpdate> Meai.IChatClient.GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        // The generated SDK does not support true SSE streaming (no IAsyncEnumerable).
        // Fall back to a non-streaming call and yield a single update.
        var request = CreateChatRequest(messages, options);
        request.Stream = false;

        var response = await V2.Chat2Async(request, cancellationToken: cancellationToken).ConfigureAwait(false);
        var chatResponse = response.Value1 ?? throw new InvalidOperationException("Expected a non-streaming response.");

        var update = new Meai.ChatResponseUpdate
        {
            ResponseId = chatResponse.Id,
            ModelId = options?.ModelId,
            Role = Meai.ChatRole.Assistant,
            FinishReason = ToFinishReason(chatResponse.FinishReason),
            RawRepresentation = chatResponse,
        };

        AddAssistantContents(update.Contents, chatResponse.Message);

        if (chatResponse.Usage?.Tokens is { } tokens)
        {
            update.Contents.Add(new Meai.UsageContent(CreateUsageDetails(tokens))
            {
                RawRepresentation = chatResponse.Usage,
            });
        }

        yield return update;
    }

    private static Chatv2Request CreateChatRequest(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options)
    {
        var requestMessages = new List<ChatMessageV2>();

        if (!string.IsNullOrWhiteSpace(options?.Instructions))
        {
            requestMessages.Add(new SystemMessageV2
            {
                Content = options!.Instructions!,
            });
        }

        foreach (var message in messages)
        {
            requestMessages.Add(ToCohereMessage(message));
        }

        var request = options?.RawRepresentationFactory?.Invoke(null!) as Chatv2Request;
        if (request is null)
        {
            request = new Chatv2Request
            {
                Model = options?.ModelId ?? "command-r-plus",
                Messages = requestMessages,
            };
        }
        else
        {
            request.Model ??= options?.ModelId ?? "command-r-plus";
            request.Messages ??= [];
            foreach (var message in requestMessages)
            {
                request.Messages.Add(message);
            }
        }

        ApplyChatOptions(request, options);
        return request;
    }

    private static ChatMessageV2 ToCohereMessage(Meai.ChatMessage message)
    {
        if (message.Role == Meai.ChatRole.System)
        {
            return new SystemMessageV2
            {
                Content = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(tc => tc.Text)),
            };
        }

        if (message.Role == Meai.ChatRole.Tool)
        {
            var functionResult = message.Contents.OfType<Meai.FunctionResultContent>().FirstOrDefault();
            return new ToolMessageV2
            {
                ToolCallId = functionResult?.CallId ?? string.Empty,
                Content = ToResultString(functionResult),
            };
        }

        if (message.Role == Meai.ChatRole.Assistant)
        {
            var toolCalls = message.Contents.OfType<Meai.FunctionCallContent>().ToList();
            var text = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(tc => tc.Text));

            var assistantMessage = new AssistantMessage
            {
                Content = string.IsNullOrEmpty(text)
                    ? null
                    : (OneOf<string, IList<ContentVariant2Item>>?)new OneOf<string, IList<ContentVariant2Item>>(text),
            };

            if (toolCalls.Count > 0)
            {
                assistantMessage.ToolCalls = toolCalls.Select(tc => new ToolCallV2
                {
                    Id = tc.CallId ?? string.Empty,
                    Type = ToolCallV2Type.Function,
                    Function = new ToolCallV2Function
                    {
                        Name = tc.Name,
                        Arguments = tc.Arguments is { } args
                            ? JsonSerializer.Serialize(args)
                            : "{}",
                    },
                }).ToList();
            }

            return assistantMessage;
        }

        // User message
        return new UserMessageV2
        {
            Content = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(tc => tc.Text)),
        };
    }

    private static void ApplyChatOptions(Chatv2Request request, Meai.ChatOptions? options)
    {
        if (options is null)
        {
            return;
        }

        request.Temperature ??= options.Temperature;
        request.P ??= options.TopP;
        request.K ??= options.TopK;
        request.MaxTokens ??= options.MaxOutputTokens;
        request.Seed ??= ToInt32(options.Seed);

        if (request.StopSequences is null && options.StopSequences is { Count: > 0 })
        {
            request.StopSequences = options.StopSequences.ToList();
        }

        if (request.ResponseFormat is null && options.ResponseFormat is Meai.ChatResponseFormatJson)
        {
            request.ResponseFormat = new JsonResponseFormatV2
            {
                Type = ResponseFormatTypeV2.JsonObject,
            };
        }

        ApplyTools(request, options);
    }

    private static void ApplyTools(Chatv2Request request, Meai.ChatOptions options)
    {
        if (options.ToolMode is Meai.NoneChatToolMode)
        {
            request.ToolChoice = Chatv2RequestToolChoice.None;
            return;
        }

        if (options.Tools is { Count: > 0 } aiTools)
        {
            request.Tools ??= [];
            foreach (var tool in aiTools)
            {
                if (tool is not Meai.AIFunction function)
                {
                    throw new NotSupportedException(
                        $"Tool type '{tool.GetType().Name}' is not supported by Cohere. Only function tools are supported.");
                }

                request.Tools.Add(new ToolV2
                {
                    Type = ToolV2Type.Function,
                    Function = new ToolV2Function
                    {
                        Name = function.Name,
                        Description = function.Description,
                        Parameters = function.JsonSchema.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined
                            ? new object()
                            : function.JsonSchema,
                    },
                });
            }
        }

        if (options.ToolMode is Meai.RequiredChatToolMode)
        {
            request.ToolChoice = Chatv2RequestToolChoice.Required;
        }
    }

    private static Meai.ChatResponse CreateChatResponse(ChatResponseV2 response, string? requestedModelId)
    {
        var responseMessage = new Meai.ChatMessage
        {
            Role = Meai.ChatRole.Assistant,
            RawRepresentation = response,
        };

        AddAssistantContents(responseMessage.Contents, response.Message);

        return new Meai.ChatResponse(responseMessage)
        {
            ResponseId = response.Id,
            ModelId = requestedModelId,
            FinishReason = ToFinishReason(response.FinishReason),
            Usage = response.Usage?.Tokens is { } tokens ? CreateUsageDetails(tokens) : null,
            RawRepresentation = response,
        };
    }

    private static void AddAssistantContents(IList<Meai.AIContent> contents, AssistantMessageResponse message)
    {
        if (message.Content is { Count: > 0 } contentItems)
        {
            foreach (var item in contentItems)
            {
                if (item.IsText && item.Text is { } textContent)
                {
                    contents.Add(new Meai.TextContent(textContent.Text)
                    {
                        RawRepresentation = textContent,
                    });
                }
                else if (item.IsThinking && item.Thinking is { } thinkingContent)
                {
                    contents.Add(new Meai.TextReasoningContent(thinkingContent.Thinking)
                    {
                        RawRepresentation = thinkingContent,
                    });
                }
            }
        }

        if (message.ToolCalls is { Count: > 0 } toolCalls)
        {
            foreach (var toolCall in toolCalls)
            {
                contents.Add(new Meai.FunctionCallContent(
                    callId: toolCall.Id,
                    name: toolCall.Function?.Name ?? string.Empty,
                    arguments: ParseArguments(toolCall.Function?.Arguments))
                {
                    RawRepresentation = toolCall,
                });
            }
        }
    }

    private static Dictionary<string, object?>? ParseArguments(string? argumentsJson)
    {
        if (string.IsNullOrWhiteSpace(argumentsJson) || argumentsJson is "{}")
        {
            return null;
        }

        try
        {
            var element = JsonSerializer.Deserialize<JsonElement>(argumentsJson);
            if (element.ValueKind == JsonValueKind.Object)
            {
                var dict = new Dictionary<string, object?>(StringComparer.Ordinal);
                foreach (var property in element.EnumerateObject())
                {
                    dict[property.Name] = property.Value;
                }

                return dict;
            }
        }
        catch (JsonException)
        {
            return null;
        }

        return null;
    }

    private static string ToResultString(Meai.FunctionResultContent? functionResult)
    {
        if (functionResult is null)
        {
            return string.Empty;
        }

        if (functionResult.Result is JsonElement jsonElement)
        {
            return jsonElement.ValueKind == JsonValueKind.String
                ? jsonElement.GetString() ?? string.Empty
                : jsonElement.GetRawText();
        }

        if (functionResult.Result is string text)
        {
            return text;
        }

        if (functionResult.Result is not null)
        {
            return JsonSerializer.Serialize(functionResult.Result);
        }

        return functionResult.Exception?.Message ?? string.Empty;
    }

    private static Meai.ChatFinishReason? ToFinishReason(ChatFinishReason finishReason) =>
        finishReason switch
        {
            ChatFinishReason.Complete => Meai.ChatFinishReason.Stop,
            ChatFinishReason.StopSequence => Meai.ChatFinishReason.Stop,
            ChatFinishReason.MaxTokens => Meai.ChatFinishReason.Length,
            ChatFinishReason.ToolCall => Meai.ChatFinishReason.ToolCalls,
            ChatFinishReason.Error => new Meai.ChatFinishReason("error"),
            ChatFinishReason.Timeout => new Meai.ChatFinishReason("timeout"),
            _ => null,
        };

    private static Meai.UsageDetails CreateUsageDetails(UsageTokens tokens) =>
        new()
        {
            InputTokenCount = (int?)tokens.InputTokens,
            OutputTokenCount = (int?)tokens.OutputTokens,
            TotalTokenCount = (int?)(tokens.InputTokens + tokens.OutputTokens),
        };

    private static int? ToInt32(long? value)
    {
        if (value is null)
        {
            return null;
        }

        if (value < int.MinValue || value > int.MaxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(value), value, "The value must fit into a 32-bit integer.");
        }

        return (int)value.Value;
    }
}
