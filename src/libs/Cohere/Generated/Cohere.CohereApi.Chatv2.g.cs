
#nullable enable

namespace Cohere
{
    public partial class CohereApi
    {
        partial void PrepareChatv2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::Cohere.Chatv2Request request);
        partial void PrepareChatv2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::Cohere.Chatv2Request request);
        partial void ProcessChatv2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatv2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Chat with the model<br/>
        /// Generates a message from the model in response to a provided conversation. To learn more about the features of the Chat API follow our [Text Generation guides](https://docs.cohere.com/v2/docs/chat-api).<br/>
        /// Follow the [Migration Guide](https://docs.cohere.com/v2/docs/migrating-v1-to-v2) for instructions on moving from API v1 to API v2.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cohere.OneOf<global::Cohere.ChatResponse, global::Cohere.StreamedChatResponseV2?>> Chatv2Async(
            global::Cohere.Chatv2Request request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareChatv2Arguments(
                httpClient: HttpClient,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v2/chat",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatv2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xClientName: xClientName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatv2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessChatv2ResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Cohere.OneOf<global::Cohere.ChatResponse, global::Cohere.StreamedChatResponseV2?>.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Chat with the model<br/>
        /// Generates a message from the model in response to a provided conversation. To learn more about the features of the Chat API follow our [Text Generation guides](https://docs.cohere.com/v2/docs/chat-api).<br/>
        /// Follow the [Migration Guide](https://docs.cohere.com/v2/docs/migrating-v1-to-v2) for instructions on moving from API v1 to API v2.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// The name of a compatible [Cohere model](https://docs.cohere.com/v2/docs/models) (such as command-r or command-r-plus) or the ID of a [fine-tuned](https://docs.cohere.com/v2/docs/chat-fine-tuning) model.
        /// </param>
        /// <param name="messages">
        /// A list of chat messages in chronological order, representing a conversation between the user and the model.<br/>
        /// Messages can be from `User`, `Assistant`, `Tool` and `System` roles. Learn more about messages and roles in [the Chat API guide](https://docs.cohere.com/v2/docs/chat-api).
        /// </param>
        /// <param name="tools">
        /// A list of available tools (functions) that the model may suggest invoking before producing a text response.<br/>
        /// When `tools` is passed (without `tool_results`), the `text` content in the response will be empty and the `tool_calls` field in the response will be populated with a list of tool calls that need to be made. If no calls need to be made, the `tool_calls` array will be empty.
        /// </param>
        /// <param name="documents">
        /// A list of relevant documents that the model can cite to generate a more accurate reply. Each document is either a string or document object with content and metadata.
        /// </param>
        /// <param name="citationOptions">
        /// Options for controlling citation generation.
        /// </param>
        /// <param name="responseFormat">
        /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/v2/docs/command-r), [Command R+](https://docs.cohere.com/v2/docs/command-r-plus) and newer models.<br/>
        /// The model can be forced into outputting JSON objects by setting `{ "type": "json_object" }`.<br/>
        /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
        /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
        /// **Note**: When `json_schema` is not specified, the generated object can have up to 5 layers of nesting.<br/>
        /// **Limitation**: The parameter is not supported when used in combinations with the `documents` or `tools` parameters.
        /// </param>
        /// <param name="safetyMode">
        /// Used to select the [safety instruction](https://docs.cohere.com/v2/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
        /// When `OFF` is specified, the safety instruction will be omitted.<br/>
        /// Safety modes are not yet configurable in combination with `tools`, `tool_results` and `documents` parameters.<br/>
        /// **Note**: This parameter is only compatible with models [Command R 08-2024](https://docs.cohere.com/v2/docs/command-r#august-2024-release), [Command R+ 08-2024](https://docs.cohere.com/v2/docs/command-r-plus#august-2024-release) and newer.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens the model will generate as part of the response.<br/>
        /// **Note**: Setting a low value may result in incomplete generations.
        /// </param>
        /// <param name="stopSequences">
        /// A list of up to 5 strings that the model will use to stop generation. If the model generates a string that matches any of the strings in the list, it will stop generating tokens and return the generated text up to that point not including the stop sequence.
        /// </param>
        /// <param name="temperature">
        /// Defaults to `0.3`.<br/>
        /// A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations, and higher temperatures mean more random generations.<br/>
        /// Randomness can be further maximized by increasing the  value of the `p` parameter.
        /// </param>
        /// <param name="seed">
        /// If specified, the backend will make a best effort to sample tokens<br/>
        /// deterministically, such that repeated requests with the same<br/>
        /// seed and parameters should return the same result. However,<br/>
        /// determinism cannot be totally guaranteed.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.
        /// </param>
        /// <param name="presencePenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.
        /// </param>
        /// <param name="k">
        /// Ensures only the top `k` most likely tokens are considered for generation at each step.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="p">
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.<br/>
        /// Default Value: 0.75F
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cohere.OneOf<global::Cohere.ChatResponse, global::Cohere.StreamedChatResponseV2?>> Chatv2Async(
            string model,
            global::System.Collections.Generic.IList<global::Cohere.ChatMessageV2> messages,
            string? xClientName = default,
            global::System.Collections.Generic.IList<global::Cohere.ToolV2>? tools = default,
            global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.Document>>? documents = default,
            global::Cohere.CitationOptions? citationOptions = default,
            global::Cohere.ResponseFormatV2? responseFormat = default,
            global::Cohere.Chatv2RequestSafetyMode? safetyMode = default,
            int? maxTokens = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            float? temperature = default,
            int? seed = default,
            float? frequencyPenalty = default,
            float? presencePenalty = default,
            float? k = 0F,
            float? p = 0.75F,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Cohere.Chatv2Request
            {
                Model = model,
                Messages = messages,
                Tools = tools,
                Documents = documents,
                CitationOptions = citationOptions,
                ResponseFormat = responseFormat,
                SafetyMode = safetyMode,
                MaxTokens = maxTokens,
                StopSequences = stopSequences,
                Temperature = temperature,
                Seed = seed,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                K = k,
                P = p,
            };

            return await Chatv2Async(
                xClientName: xClientName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}