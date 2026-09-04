
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Cohere
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRole), TypeInfoPropertyName = "ChatRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Message), TypeInfoPropertyName = "Message2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.MessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.MessageDiscriminatorRole), TypeInfoPropertyName = "MessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cohere.ToolParameterDefinitionsValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolParameterDefinitionsValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatType), TypeInfoPropertyName = "ResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.JSONResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatDiscriminatorType), TypeInfoPropertyName = "ResponseFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationType), TypeInfoPropertyName = "ChatCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ApiMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ApiMetaApiVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ApiMetaBilledUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ApiMetaTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NonStreamedChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ChatCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ChatDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ChatSearchQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ChatSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEventEventType), TypeInfoPropertyName = "ChatStreamEventEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamStartEvent), TypeInfoPropertyName = "ChatStreamStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamStartEvent5v9jyv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQueriesGenerationEvent), TypeInfoPropertyName = "ChatSearchQueriesGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQueriesGenerationEvent6evypd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultsEvent), TypeInfoPropertyName = "ChatSearchResultsEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultsEvent44axt5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextGenerationEvent), TypeInfoPropertyName = "ChatTextGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextGenerationEvent8yyj22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationGenerationEvent), TypeInfoPropertyName = "ChatCitationGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationGenerationEventLg3v2o))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsGenerationEvent), TypeInfoPropertyName = "ChatToolCallsGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsGenerationEventNykiww))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEvent), TypeInfoPropertyName = "ChatStreamEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEventY8gq2x))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEventFinishReason), TypeInfoPropertyName = "ChatStreamEndEventFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsChunkEvent), TypeInfoPropertyName = "ChatToolCallsChunkEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsChunkEventT7lliu))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDebugEvent), TypeInfoPropertyName = "ChatDebugEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDebugEvent352j0t))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponse), TypeInfoPropertyName = "StreamedChatResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseDiscriminatorEventType), TypeInfoPropertyName = "StreamedChatResponseDiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextContentType), TypeInfoPropertyName = "ChatTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentType), TypeInfoPropertyName = "ContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ImageUrlDetail), TypeInfoPropertyName = "ImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Content), TypeInfoPropertyName = "Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentDiscriminatorType), TypeInfoPropertyName = "ContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UserMessageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UserMessageV2Role), TypeInfoPropertyName = "UserMessageV2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.Content>>), TypeInfoPropertyName = "OneOfStringIListContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Content>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallV2Type), TypeInfoPropertyName = "ToolCallV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallV2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatThinkingContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatThinkingContentType), TypeInfoPropertyName = "ChatThinkingContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Source), TypeInfoPropertyName = "Source2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SourceDiscriminatorType), TypeInfoPropertyName = "SourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationType), TypeInfoPropertyName = "CitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Citation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageRole), TypeInfoPropertyName = "AssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolCallV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListContentVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentVariant2Item), TypeInfoPropertyName = "ContentVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageV2ContentOneItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType), TypeInfoPropertyName = "AssistantMessageV2ContentOneItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Citation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2Role), TypeInfoPropertyName = "SystemMessageV2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>>), TypeInfoPropertyName = "OneOfStringIListContentVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentVariant2Item2), TypeInfoPropertyName = "ContentVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminatorType), TypeInfoPropertyName = "SystemMessageV2ContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DocumentContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DocumentContentType), TypeInfoPropertyName = "DocumentContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolContent), TypeInfoPropertyName = "ToolContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolContentDiscriminatorType), TypeInfoPropertyName = "ToolContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolMessageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolMessageV2Role), TypeInfoPropertyName = "ToolMessageV2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>>), TypeInfoPropertyName = "OneOfStringIListToolContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageV2), TypeInfoPropertyName = "ChatMessageV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageV2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageV2DiscriminatorRole), TypeInfoPropertyName = "ChatMessageV2DiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ChatMessageV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolV2Type), TypeInfoPropertyName = "ToolV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolV2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationOptionsMode), TypeInfoPropertyName = "CitationOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TruncationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatTypeV2), TypeInfoPropertyName = "ResponseFormatTypeV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextResponseFormatV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.JsonResponseFormatV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatV2), TypeInfoPropertyName = "ResponseFormatV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatV2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatV2DiscriminatorType), TypeInfoPropertyName = "ResponseFormatV2DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Thinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ThinkingType), TypeInfoPropertyName = "ThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatFinishReason), TypeInfoPropertyName = "ChatFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponseRole), TypeInfoPropertyName = "AssistantMessageResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentItem), TypeInfoPropertyName = "ContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminatorType), TypeInfoPropertyName = "AssistantMessageResponseContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UsageBilledUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UsageTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.LogprobItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.LogprobItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEventTypeType), TypeInfoPropertyName = "ChatStreamEventTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEvent), TypeInfoPropertyName = "ChatMessageStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventLsegeq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventDeltaMessageRole), TypeInfoPropertyName = "ChatMessageStartEventDeltaMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEvent), TypeInfoPropertyName = "ChatContentStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEvent6xvlq1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDeltaMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDeltaMessageContentType), TypeInfoPropertyName = "ChatContentStartEventDeltaMessageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEvent), TypeInfoPropertyName = "ChatContentDeltaEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEvent3m0vqs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventDeltaMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentEndEvent), TypeInfoPropertyName = "ChatContentEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentEndEventMa278i))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEvent), TypeInfoPropertyName = "ChatToolPlanDeltaEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEvent2obfex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEvent), TypeInfoPropertyName = "ChatToolCallStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventLv559x))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEvent), TypeInfoPropertyName = "ChatToolCallDeltaEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEvent2bxzoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventDeltaMessageToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventDeltaMessageToolCallsFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallEndEvent), TypeInfoPropertyName = "ChatToolCallEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallEndEventT6ph9s))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEvent), TypeInfoPropertyName = "CitationStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventT3df62))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationEndEvent), TypeInfoPropertyName = "CitationEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationEndEventFs3igt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEvent), TypeInfoPropertyName = "ChatMessageEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEventU3fzny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2), TypeInfoPropertyName = "StreamedChatResponseV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2DiscriminatorType), TypeInfoPropertyName = "StreamedChatResponseV2DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.PromptResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseDocumentType), TypeInfoPropertyName = "ParseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseOutputFormat), TypeInfoPropertyName = "ParseOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTextContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTextContentBlockType), TypeInfoPropertyName = "ParseTextContentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseImageCategory), TypeInfoPropertyName = "ParseImageCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBoundingBoxNormalized))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseImageBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseImageContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseImageContentBlockType), TypeInfoPropertyName = "ParseImageContentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTableContentType), TypeInfoPropertyName = "ParseTableContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTableBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTableContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTableContentBlockType), TypeInfoPropertyName = "ParseTableContentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBlock), TypeInfoPropertyName = "ParseBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBlockDiscriminatorType), TypeInfoPropertyName = "ParseBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBlocksPageVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBlocksPageVariantType), TypeInfoPropertyName = "ParseBlocksPageVariantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ParseBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseMarkdownPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ParseImageBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseMarkdownPageVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseMarkdownPageVariantType), TypeInfoPropertyName = "ParseMarkdownPageVariantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParsePage), TypeInfoPropertyName = "ParsePage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParsePageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParsePageDiscriminatorType), TypeInfoPropertyName = "ParsePageDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ParsePage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGenerationTokenLikelihoodsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGenerationTokenLikelihoodsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Generation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEventEventType), TypeInfoPropertyName = "GenerateStreamEventEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamText), TypeInfoPropertyName = "GenerateStreamText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamTextYai5v6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGenerationInStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEnd), TypeInfoPropertyName = "GenerateStreamEnd2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEndUbzr0t))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEndResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGenerationInStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamError), TypeInfoPropertyName = "GenerateStreamError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamError49d5xw))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamedResponse), TypeInfoPropertyName = "GenerateStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamedResponseDiscriminatorEventType), TypeInfoPropertyName = "GenerateStreamedResponseDiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedInputType), TypeInfoPropertyName = "EmbedInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbeddingType), TypeInfoPropertyName = "EmbeddingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedFloatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedFloatsResponseResponseType), TypeInfoPropertyName = "EmbedFloatsResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedByTypeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedByTypeResponseResponseType), TypeInfoPropertyName = "EmbedByTypeResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedByTypeResponseEmbeddings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContentType), TypeInfoPropertyName = "EmbedContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContent), TypeInfoPropertyName = "EmbedContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContentDiscriminatorType), TypeInfoPropertyName = "EmbedContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BatchStatus), TypeInfoPropertyName = "BatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BatchError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RetryBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedJobStatus), TypeInfoPropertyName = "EmbedJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedJobTruncate), TypeInfoPropertyName = "EmbedJobTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbedJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbeddingType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobRequestTruncate), TypeInfoPropertyName = "CreateEmbedJobRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetValidationStatus), TypeInfoPropertyName = "DatasetValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetType), TypeInfoPropertyName = "DatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankerDataMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDataMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.LabelMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyDataMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.LabelMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.FinetuneDatasetMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Metrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.DatasetPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ConnectorOAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Connector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ConnectorAuthStatus), TypeInfoPropertyName = "ConnectorAuthStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Connector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorOAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AuthTokenType), TypeInfoPropertyName = "AuthTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorServiceAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ConnectorLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorsLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ConnectorLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.FeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenLikelihood))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.LogLikelihoodResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.TokenLikelihood>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Cluster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetClusterJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetClusterJobResponseStatus), TypeInfoPropertyName = "GetClusterJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Cluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListClusterJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.GetClusterJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateClusterJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateClusterJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateClusterJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateClusterJobRequestStatus), TypeInfoPropertyName = "UpdateClusterJobRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateClusterJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CompatibleEndpoint), TypeInfoPropertyName = "CompatibleEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.CompatibleEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponseSamplingDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.GetModelResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BaseType), TypeInfoPropertyName = "BaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Strategy), TypeInfoPropertyName = "Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BaseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.LoraTargetModules), TypeInfoPropertyName = "LoraTargetModules2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Hyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.WandbConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Settings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Status), TypeInfoPropertyName = "Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.FinetunedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListFinetunedModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.FinetunedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateFinetunedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetFinetunedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteFinetunedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateFinetunedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TrainingStepMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListTrainingStepMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.TrainingStepMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestPromptTruncation), TypeInfoPropertyName = "ChatRequestPromptTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ChatConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestCitationQuality), TypeInfoPropertyName = "ChatRequestCitationQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestSafetyMode), TypeInfoPropertyName = "ChatRequestSafetyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.Document>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::Cohere.Document>), TypeInfoPropertyName = "OneOfStringDocument2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2RequestSafetyMode), TypeInfoPropertyName = "Chatv2RequestSafetyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2RequestToolChoice), TypeInfoPropertyName = "Chatv2RequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateRequestTruncate), TypeInfoPropertyName = "GenerateRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateRequestReturnLikelihoods), TypeInfoPropertyName = "GenerateRequestReturnLikelihoods2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedRequestTruncate), TypeInfoPropertyName = "EmbedRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2EmbedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbedInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2EmbedRequestTruncate), TypeInfoPropertyName = "V2EmbedRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AudioTranscriptionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.RerankDocument>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::Cohere.RerankDocument>), TypeInfoPropertyName = "OneOfStringRerankDocument2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ClassifyExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyRequestTruncate), TypeInfoPropertyName = "ClassifyRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetDytngn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestLength), TypeInfoPropertyName = "SummarizeRequestLength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestFormat), TypeInfoPropertyName = "SummarizeRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestExtractiveness), TypeInfoPropertyName = "SummarizeRequestExtractiveness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.FinetuningUpdateFinetunedModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatAccepts), TypeInfoPropertyName = "ChatAccepts2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>), TypeInfoPropertyName = "OneOfNonStreamedChatResponseStreamedChatResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<global::Cohere.ChatResponseV2, global::Cohere.StreamedChatResponseV2?>), TypeInfoPropertyName = "OneOfChatResponseV2StreamedChatResponseV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse), TypeInfoPropertyName = "EmbedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponseDiscriminatorResponseType), TypeInfoPropertyName = "EmbedResponseDiscriminatorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AudioTranscriptionsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody7))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.RerankResponseResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponseResultsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponseResultsItemDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2RerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.V2RerankResponseResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2RerankResponseResultsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ClassifyResponseClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cohere.ClassifyResponseClassificationLabels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassificationLabels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassificationClassificationType), TypeInfoPropertyName = "ClassifyResponseClassificationClassificationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetsGetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody33))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody34))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetsGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody35))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody36))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody37))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody38))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody39))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody40))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody41))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody43))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody44))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody45))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody46))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody47))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody48))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody49))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody50))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody51))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody53))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody54))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody55))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody56))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody57))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody58))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody59))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody60))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody61))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody62))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InternalServerErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ServiceUnavailableErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotImplementedErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TooManyRequestsErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.InvalidTokenErrorBody31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRole?), TypeInfoPropertyName = "NullableChatRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Message?), TypeInfoPropertyName = "NullableMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.MessageDiscriminatorRole?), TypeInfoPropertyName = "NullableMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatType?), TypeInfoPropertyName = "NullableResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormat?), TypeInfoPropertyName = "NullableResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatDiscriminatorType?), TypeInfoPropertyName = "NullableResponseFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationType?), TypeInfoPropertyName = "NullableChatCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.FinishReason?), TypeInfoPropertyName = "NullableFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEventEventType?), TypeInfoPropertyName = "NullableChatStreamEventEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamStartEvent?), TypeInfoPropertyName = "NullableChatStreamStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQueriesGenerationEvent?), TypeInfoPropertyName = "NullableChatSearchQueriesGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultsEvent?), TypeInfoPropertyName = "NullableChatSearchResultsEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextGenerationEvent?), TypeInfoPropertyName = "NullableChatTextGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationGenerationEvent?), TypeInfoPropertyName = "NullableChatCitationGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsGenerationEvent?), TypeInfoPropertyName = "NullableChatToolCallsGenerationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEvent?), TypeInfoPropertyName = "NullableChatStreamEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEventFinishReason?), TypeInfoPropertyName = "NullableChatStreamEndEventFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsChunkEvent?), TypeInfoPropertyName = "NullableChatToolCallsChunkEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDebugEvent?), TypeInfoPropertyName = "NullableChatDebugEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponse?), TypeInfoPropertyName = "NullableStreamedChatResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseDiscriminatorEventType?), TypeInfoPropertyName = "NullableStreamedChatResponseDiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextContentType?), TypeInfoPropertyName = "NullableChatTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentType?), TypeInfoPropertyName = "NullableContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ImageUrlDetail?), TypeInfoPropertyName = "NullableImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Content?), TypeInfoPropertyName = "NullableContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentDiscriminatorType?), TypeInfoPropertyName = "NullableContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UserMessageV2Role?), TypeInfoPropertyName = "NullableUserMessageV2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.Content>>?), TypeInfoPropertyName = "NullableOneOfStringIListContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallV2Type?), TypeInfoPropertyName = "NullableToolCallV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatThinkingContentType?), TypeInfoPropertyName = "NullableChatThinkingContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Source?), TypeInfoPropertyName = "NullableSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SourceDiscriminatorType?), TypeInfoPropertyName = "NullableSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationType?), TypeInfoPropertyName = "NullableCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageRole?), TypeInfoPropertyName = "NullableAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>>?), TypeInfoPropertyName = "NullableOneOfStringIListContentVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentVariant2Item?), TypeInfoPropertyName = "NullableContentVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType?), TypeInfoPropertyName = "NullableAssistantMessageV2ContentOneItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2Role?), TypeInfoPropertyName = "NullableSystemMessageV2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>>?), TypeInfoPropertyName = "NullableOneOfStringIListContentVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentVariant2Item2?), TypeInfoPropertyName = "NullableContentVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullableSystemMessageV2ContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DocumentContentType?), TypeInfoPropertyName = "NullableDocumentContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolContent?), TypeInfoPropertyName = "NullableToolContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolContentDiscriminatorType?), TypeInfoPropertyName = "NullableToolContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolMessageV2Role?), TypeInfoPropertyName = "NullableToolMessageV2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>>?), TypeInfoPropertyName = "NullableOneOfStringIListToolContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageV2?), TypeInfoPropertyName = "NullableChatMessageV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageV2DiscriminatorRole?), TypeInfoPropertyName = "NullableChatMessageV2DiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolV2Type?), TypeInfoPropertyName = "NullableToolV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationOptionsMode?), TypeInfoPropertyName = "NullableCitationOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatTypeV2?), TypeInfoPropertyName = "NullableResponseFormatTypeV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatV2?), TypeInfoPropertyName = "NullableResponseFormatV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatV2DiscriminatorType?), TypeInfoPropertyName = "NullableResponseFormatV2DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ThinkingType?), TypeInfoPropertyName = "NullableThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatFinishReason?), TypeInfoPropertyName = "NullableChatFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponseRole?), TypeInfoPropertyName = "NullableAssistantMessageResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentItem?), TypeInfoPropertyName = "NullableContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableAssistantMessageResponseContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEventTypeType?), TypeInfoPropertyName = "NullableChatStreamEventTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEvent?), TypeInfoPropertyName = "NullableChatMessageStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventDeltaMessageRole?), TypeInfoPropertyName = "NullableChatMessageStartEventDeltaMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEvent?), TypeInfoPropertyName = "NullableChatContentStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDeltaMessageContentType?), TypeInfoPropertyName = "NullableChatContentStartEventDeltaMessageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEvent?), TypeInfoPropertyName = "NullableChatContentDeltaEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentEndEvent?), TypeInfoPropertyName = "NullableChatContentEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEvent?), TypeInfoPropertyName = "NullableChatToolPlanDeltaEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEvent?), TypeInfoPropertyName = "NullableChatToolCallStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEvent?), TypeInfoPropertyName = "NullableChatToolCallDeltaEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallEndEvent?), TypeInfoPropertyName = "NullableChatToolCallEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEvent?), TypeInfoPropertyName = "NullableCitationStartEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationEndEvent?), TypeInfoPropertyName = "NullableCitationEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEvent?), TypeInfoPropertyName = "NullableChatMessageEndEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2?), TypeInfoPropertyName = "NullableStreamedChatResponseV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2DiscriminatorType?), TypeInfoPropertyName = "NullableStreamedChatResponseV2DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseDocumentType?), TypeInfoPropertyName = "NullableParseDocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseOutputFormat?), TypeInfoPropertyName = "NullableParseOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTextContentBlockType?), TypeInfoPropertyName = "NullableParseTextContentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseImageCategory?), TypeInfoPropertyName = "NullableParseImageCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseImageContentBlockType?), TypeInfoPropertyName = "NullableParseImageContentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTableContentType?), TypeInfoPropertyName = "NullableParseTableContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseTableContentBlockType?), TypeInfoPropertyName = "NullableParseTableContentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBlock?), TypeInfoPropertyName = "NullableParseBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBlockDiscriminatorType?), TypeInfoPropertyName = "NullableParseBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseBlocksPageVariantType?), TypeInfoPropertyName = "NullableParseBlocksPageVariantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParseMarkdownPageVariantType?), TypeInfoPropertyName = "NullableParseMarkdownPageVariantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParsePage?), TypeInfoPropertyName = "NullableParsePage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ParsePageDiscriminatorType?), TypeInfoPropertyName = "NullableParsePageDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEventEventType?), TypeInfoPropertyName = "NullableGenerateStreamEventEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamText?), TypeInfoPropertyName = "NullableGenerateStreamText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEnd?), TypeInfoPropertyName = "NullableGenerateStreamEnd2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamError?), TypeInfoPropertyName = "NullableGenerateStreamError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamedResponse?), TypeInfoPropertyName = "NullableGenerateStreamedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamedResponseDiscriminatorEventType?), TypeInfoPropertyName = "NullableGenerateStreamedResponseDiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedInputType?), TypeInfoPropertyName = "NullableEmbedInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbeddingType?), TypeInfoPropertyName = "NullableEmbeddingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedFloatsResponseResponseType?), TypeInfoPropertyName = "NullableEmbedFloatsResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedByTypeResponseResponseType?), TypeInfoPropertyName = "NullableEmbedByTypeResponseResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContentType?), TypeInfoPropertyName = "NullableEmbedContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContent?), TypeInfoPropertyName = "NullableEmbedContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContentDiscriminatorType?), TypeInfoPropertyName = "NullableEmbedContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BatchStatus?), TypeInfoPropertyName = "NullableBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedJobStatus?), TypeInfoPropertyName = "NullableEmbedJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedJobTruncate?), TypeInfoPropertyName = "NullableEmbedJobTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobRequestTruncate?), TypeInfoPropertyName = "NullableCreateEmbedJobRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetValidationStatus?), TypeInfoPropertyName = "NullableDatasetValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetType?), TypeInfoPropertyName = "NullableDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ConnectorAuthStatus?), TypeInfoPropertyName = "NullableConnectorAuthStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AuthTokenType?), TypeInfoPropertyName = "NullableAuthTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetClusterJobResponseStatus?), TypeInfoPropertyName = "NullableGetClusterJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateClusterJobRequestStatus?), TypeInfoPropertyName = "NullableUpdateClusterJobRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CompatibleEndpoint?), TypeInfoPropertyName = "NullableCompatibleEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BaseType?), TypeInfoPropertyName = "NullableBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Strategy?), TypeInfoPropertyName = "NullableStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.LoraTargetModules?), TypeInfoPropertyName = "NullableLoraTargetModules2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Status?), TypeInfoPropertyName = "NullableStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestPromptTruncation?), TypeInfoPropertyName = "NullableChatRequestPromptTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestCitationQuality?), TypeInfoPropertyName = "NullableChatRequestCitationQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestSafetyMode?), TypeInfoPropertyName = "NullableChatRequestSafetyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::Cohere.Document>?), TypeInfoPropertyName = "NullableOneOfStringDocument2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2RequestSafetyMode?), TypeInfoPropertyName = "NullableChatv2RequestSafetyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2RequestToolChoice?), TypeInfoPropertyName = "NullableChatv2RequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateRequestTruncate?), TypeInfoPropertyName = "NullableGenerateRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateRequestReturnLikelihoods?), TypeInfoPropertyName = "NullableGenerateRequestReturnLikelihoods2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedRequestTruncate?), TypeInfoPropertyName = "NullableEmbedRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2EmbedRequestTruncate?), TypeInfoPropertyName = "NullableV2EmbedRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::Cohere.RerankDocument>?), TypeInfoPropertyName = "NullableOneOfStringRerankDocument2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyRequestTruncate?), TypeInfoPropertyName = "NullableClassifyRequestTruncate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestLength?), TypeInfoPropertyName = "NullableSummarizeRequestLength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestFormat?), TypeInfoPropertyName = "NullableSummarizeRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestExtractiveness?), TypeInfoPropertyName = "NullableSummarizeRequestExtractiveness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatAccepts?), TypeInfoPropertyName = "NullableChatAccepts2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>?), TypeInfoPropertyName = "NullableOneOfNonStreamedChatResponseStreamedChatResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<global::Cohere.ChatResponseV2, global::Cohere.StreamedChatResponseV2?>?), TypeInfoPropertyName = "NullableOneOfChatResponseV2StreamedChatResponseV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse?), TypeInfoPropertyName = "NullableEmbedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponseDiscriminatorResponseType?), TypeInfoPropertyName = "NullableEmbedResponseDiscriminatorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassificationClassificationType?), TypeInfoPropertyName = "NullableClassifyResponseClassificationClassificationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ChatCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ChatDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ChatSearchQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ChatSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.List<global::Cohere.Content>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Content>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ToolCallV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.List<global::Cohere.ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Citation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.List<global::Cohere.ContentVariant2Item2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ContentVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.List<global::Cohere.ToolContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ToolContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ChatMessageV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.LogprobItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ParseBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ParseImageBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ParsePage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.SingleGenerationTokenLikelihoodsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.SingleGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.SingleGenerationInStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.EmbedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.EmbedJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.EmbeddingType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.LabelMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.DatasetPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Connector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ConnectorLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.TokenLikelihood>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Cluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.GetClusterJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.CompatibleEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.GetModelResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.FinetunedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.TrainingStepMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ChatConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ToolV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.OneOf<string, global::Cohere.Document>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.EmbedInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.OneOf<string, global::Cohere.RerankDocument>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ClassifyExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.RerankResponseResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.V2RerankResponseResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ClassifyResponseClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Dataset>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Cohere.JsonConverters.MessageJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ResponseFormatJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatStreamStartEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatSearchQueriesGenerationEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatSearchResultsEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatTextGenerationEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatCitationGenerationEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatToolCallsGenerationEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatStreamEndEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatToolCallsChunkEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatDebugEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.StreamedChatResponseJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ContentJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.SourceJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ContentVariant2ItemJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ContentVariant2Item2JsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ToolContentJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatMessageV2JsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ResponseFormatV2JsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ContentItemJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatMessageStartEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatContentStartEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatContentDeltaEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatContentEndEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatToolPlanDeltaEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatToolCallStartEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatToolCallDeltaEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatToolCallEndEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.CitationStartEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.CitationEndEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ChatMessageEndEventJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.StreamedChatResponseV2JsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ParseBlockJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.ParsePageJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.GenerateStreamTextJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.GenerateStreamEndJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.GenerateStreamErrorJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.GenerateStreamedResponseJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.EmbedContentJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.EmbedResponseJsonConverter());
            options.Converters.Add(new global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.Content>>());
            options.Converters.Add(new global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>>());
            options.Converters.Add(new global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>>());
            options.Converters.Add(new global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>>());
            options.Converters.Add(new global::Cohere.JsonConverters.OneOfJsonConverter<string, global::Cohere.Document>());
            options.Converters.Add(new global::Cohere.JsonConverters.OneOfJsonConverter<string, global::Cohere.RerankDocument>());
            options.Converters.Add(new global::Cohere.JsonConverters.OneOfJsonConverter<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>());
            options.Converters.Add(new global::Cohere.JsonConverters.OneOfJsonConverter<global::Cohere.ChatResponseV2, global::Cohere.StreamedChatResponseV2?>());
            options.Converters.Add(new global::Cohere.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Cohere.ChatRole)

                    || typeToConvert == typeof(global::Cohere.ChatRole?)

                    || typeToConvert == typeof(global::Cohere.MessageDiscriminatorRole)

                    || typeToConvert == typeof(global::Cohere.MessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::Cohere.ResponseFormatType)

                    || typeToConvert == typeof(global::Cohere.ResponseFormatType?)

                    || typeToConvert == typeof(global::Cohere.ResponseFormatDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.ResponseFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.ChatCitationType)

                    || typeToConvert == typeof(global::Cohere.ChatCitationType?)

                    || typeToConvert == typeof(global::Cohere.FinishReason)

                    || typeToConvert == typeof(global::Cohere.FinishReason?)

                    || typeToConvert == typeof(global::Cohere.ChatStreamEventEventType)

                    || typeToConvert == typeof(global::Cohere.ChatStreamEventEventType?)

                    || typeToConvert == typeof(global::Cohere.ChatStreamEndEventFinishReason)

                    || typeToConvert == typeof(global::Cohere.ChatStreamEndEventFinishReason?)

                    || typeToConvert == typeof(global::Cohere.StreamedChatResponseDiscriminatorEventType)

                    || typeToConvert == typeof(global::Cohere.StreamedChatResponseDiscriminatorEventType?)

                    || typeToConvert == typeof(global::Cohere.ChatTextContentType)

                    || typeToConvert == typeof(global::Cohere.ChatTextContentType?)

                    || typeToConvert == typeof(global::Cohere.ContentType)

                    || typeToConvert == typeof(global::Cohere.ContentType?)

                    || typeToConvert == typeof(global::Cohere.ImageUrlDetail)

                    || typeToConvert == typeof(global::Cohere.ImageUrlDetail?)

                    || typeToConvert == typeof(global::Cohere.ContentDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.ContentDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.UserMessageV2Role)

                    || typeToConvert == typeof(global::Cohere.UserMessageV2Role?)

                    || typeToConvert == typeof(global::Cohere.ToolCallV2Type)

                    || typeToConvert == typeof(global::Cohere.ToolCallV2Type?)

                    || typeToConvert == typeof(global::Cohere.ChatThinkingContentType)

                    || typeToConvert == typeof(global::Cohere.ChatThinkingContentType?)

                    || typeToConvert == typeof(global::Cohere.SourceDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.SourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.CitationType)

                    || typeToConvert == typeof(global::Cohere.CitationType?)

                    || typeToConvert == typeof(global::Cohere.AssistantMessageRole)

                    || typeToConvert == typeof(global::Cohere.AssistantMessageRole?)

                    || typeToConvert == typeof(global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.SystemMessageV2Role)

                    || typeToConvert == typeof(global::Cohere.SystemMessageV2Role?)

                    || typeToConvert == typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.DocumentContentType)

                    || typeToConvert == typeof(global::Cohere.DocumentContentType?)

                    || typeToConvert == typeof(global::Cohere.ToolContentDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.ToolContentDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.ToolMessageV2Role)

                    || typeToConvert == typeof(global::Cohere.ToolMessageV2Role?)

                    || typeToConvert == typeof(global::Cohere.ChatMessageV2DiscriminatorRole)

                    || typeToConvert == typeof(global::Cohere.ChatMessageV2DiscriminatorRole?)

                    || typeToConvert == typeof(global::Cohere.ToolV2Type)

                    || typeToConvert == typeof(global::Cohere.ToolV2Type?)

                    || typeToConvert == typeof(global::Cohere.CitationOptionsMode)

                    || typeToConvert == typeof(global::Cohere.CitationOptionsMode?)

                    || typeToConvert == typeof(global::Cohere.ResponseFormatTypeV2)

                    || typeToConvert == typeof(global::Cohere.ResponseFormatTypeV2?)

                    || typeToConvert == typeof(global::Cohere.ResponseFormatV2DiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.ResponseFormatV2DiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.ThinkingType)

                    || typeToConvert == typeof(global::Cohere.ThinkingType?)

                    || typeToConvert == typeof(global::Cohere.ChatFinishReason)

                    || typeToConvert == typeof(global::Cohere.ChatFinishReason?)

                    || typeToConvert == typeof(global::Cohere.AssistantMessageResponseRole)

                    || typeToConvert == typeof(global::Cohere.AssistantMessageResponseRole?)

                    || typeToConvert == typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.ChatStreamEventTypeType)

                    || typeToConvert == typeof(global::Cohere.ChatStreamEventTypeType?)

                    || typeToConvert == typeof(global::Cohere.ChatMessageStartEventDeltaMessageRole)

                    || typeToConvert == typeof(global::Cohere.ChatMessageStartEventDeltaMessageRole?)

                    || typeToConvert == typeof(global::Cohere.ChatContentStartEventDeltaMessageContentType)

                    || typeToConvert == typeof(global::Cohere.ChatContentStartEventDeltaMessageContentType?)

                    || typeToConvert == typeof(global::Cohere.StreamedChatResponseV2DiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.StreamedChatResponseV2DiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.ParseDocumentType)

                    || typeToConvert == typeof(global::Cohere.ParseDocumentType?)

                    || typeToConvert == typeof(global::Cohere.ParseOutputFormat)

                    || typeToConvert == typeof(global::Cohere.ParseOutputFormat?)

                    || typeToConvert == typeof(global::Cohere.ParseTextContentBlockType)

                    || typeToConvert == typeof(global::Cohere.ParseTextContentBlockType?)

                    || typeToConvert == typeof(global::Cohere.ParseImageCategory)

                    || typeToConvert == typeof(global::Cohere.ParseImageCategory?)

                    || typeToConvert == typeof(global::Cohere.ParseImageContentBlockType)

                    || typeToConvert == typeof(global::Cohere.ParseImageContentBlockType?)

                    || typeToConvert == typeof(global::Cohere.ParseTableContentType)

                    || typeToConvert == typeof(global::Cohere.ParseTableContentType?)

                    || typeToConvert == typeof(global::Cohere.ParseTableContentBlockType)

                    || typeToConvert == typeof(global::Cohere.ParseTableContentBlockType?)

                    || typeToConvert == typeof(global::Cohere.ParseBlockDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.ParseBlockDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.ParseBlocksPageVariantType)

                    || typeToConvert == typeof(global::Cohere.ParseBlocksPageVariantType?)

                    || typeToConvert == typeof(global::Cohere.ParseMarkdownPageVariantType)

                    || typeToConvert == typeof(global::Cohere.ParseMarkdownPageVariantType?)

                    || typeToConvert == typeof(global::Cohere.ParsePageDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.ParsePageDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.GenerateStreamEventEventType)

                    || typeToConvert == typeof(global::Cohere.GenerateStreamEventEventType?)

                    || typeToConvert == typeof(global::Cohere.GenerateStreamedResponseDiscriminatorEventType)

                    || typeToConvert == typeof(global::Cohere.GenerateStreamedResponseDiscriminatorEventType?)

                    || typeToConvert == typeof(global::Cohere.EmbedInputType)

                    || typeToConvert == typeof(global::Cohere.EmbedInputType?)

                    || typeToConvert == typeof(global::Cohere.EmbeddingType)

                    || typeToConvert == typeof(global::Cohere.EmbeddingType?)

                    || typeToConvert == typeof(global::Cohere.EmbedFloatsResponseResponseType)

                    || typeToConvert == typeof(global::Cohere.EmbedFloatsResponseResponseType?)

                    || typeToConvert == typeof(global::Cohere.EmbedByTypeResponseResponseType)

                    || typeToConvert == typeof(global::Cohere.EmbedByTypeResponseResponseType?)

                    || typeToConvert == typeof(global::Cohere.EmbedContentType)

                    || typeToConvert == typeof(global::Cohere.EmbedContentType?)

                    || typeToConvert == typeof(global::Cohere.EmbedContentDiscriminatorType)

                    || typeToConvert == typeof(global::Cohere.EmbedContentDiscriminatorType?)

                    || typeToConvert == typeof(global::Cohere.BatchStatus)

                    || typeToConvert == typeof(global::Cohere.BatchStatus?)

                    || typeToConvert == typeof(global::Cohere.EmbedJobStatus)

                    || typeToConvert == typeof(global::Cohere.EmbedJobStatus?)

                    || typeToConvert == typeof(global::Cohere.EmbedJobTruncate)

                    || typeToConvert == typeof(global::Cohere.EmbedJobTruncate?)

                    || typeToConvert == typeof(global::Cohere.CreateEmbedJobRequestTruncate)

                    || typeToConvert == typeof(global::Cohere.CreateEmbedJobRequestTruncate?)

                    || typeToConvert == typeof(global::Cohere.DatasetValidationStatus)

                    || typeToConvert == typeof(global::Cohere.DatasetValidationStatus?)

                    || typeToConvert == typeof(global::Cohere.DatasetType)

                    || typeToConvert == typeof(global::Cohere.DatasetType?)

                    || typeToConvert == typeof(global::Cohere.ConnectorAuthStatus)

                    || typeToConvert == typeof(global::Cohere.ConnectorAuthStatus?)

                    || typeToConvert == typeof(global::Cohere.AuthTokenType)

                    || typeToConvert == typeof(global::Cohere.AuthTokenType?)

                    || typeToConvert == typeof(global::Cohere.GetClusterJobResponseStatus)

                    || typeToConvert == typeof(global::Cohere.GetClusterJobResponseStatus?)

                    || typeToConvert == typeof(global::Cohere.UpdateClusterJobRequestStatus)

                    || typeToConvert == typeof(global::Cohere.UpdateClusterJobRequestStatus?)

                    || typeToConvert == typeof(global::Cohere.CompatibleEndpoint)

                    || typeToConvert == typeof(global::Cohere.CompatibleEndpoint?)

                    || typeToConvert == typeof(global::Cohere.BaseType)

                    || typeToConvert == typeof(global::Cohere.BaseType?)

                    || typeToConvert == typeof(global::Cohere.Strategy)

                    || typeToConvert == typeof(global::Cohere.Strategy?)

                    || typeToConvert == typeof(global::Cohere.LoraTargetModules)

                    || typeToConvert == typeof(global::Cohere.LoraTargetModules?)

                    || typeToConvert == typeof(global::Cohere.Status)

                    || typeToConvert == typeof(global::Cohere.Status?)

                    || typeToConvert == typeof(global::Cohere.ChatRequestPromptTruncation)

                    || typeToConvert == typeof(global::Cohere.ChatRequestPromptTruncation?)

                    || typeToConvert == typeof(global::Cohere.ChatRequestCitationQuality)

                    || typeToConvert == typeof(global::Cohere.ChatRequestCitationQuality?)

                    || typeToConvert == typeof(global::Cohere.ChatRequestSafetyMode)

                    || typeToConvert == typeof(global::Cohere.ChatRequestSafetyMode?)

                    || typeToConvert == typeof(global::Cohere.Chatv2RequestSafetyMode)

                    || typeToConvert == typeof(global::Cohere.Chatv2RequestSafetyMode?)

                    || typeToConvert == typeof(global::Cohere.Chatv2RequestToolChoice)

                    || typeToConvert == typeof(global::Cohere.Chatv2RequestToolChoice?)

                    || typeToConvert == typeof(global::Cohere.GenerateRequestTruncate)

                    || typeToConvert == typeof(global::Cohere.GenerateRequestTruncate?)

                    || typeToConvert == typeof(global::Cohere.GenerateRequestReturnLikelihoods)

                    || typeToConvert == typeof(global::Cohere.GenerateRequestReturnLikelihoods?)

                    || typeToConvert == typeof(global::Cohere.EmbedRequestTruncate)

                    || typeToConvert == typeof(global::Cohere.EmbedRequestTruncate?)

                    || typeToConvert == typeof(global::Cohere.V2EmbedRequestTruncate)

                    || typeToConvert == typeof(global::Cohere.V2EmbedRequestTruncate?)

                    || typeToConvert == typeof(global::Cohere.ClassifyRequestTruncate)

                    || typeToConvert == typeof(global::Cohere.ClassifyRequestTruncate?)

                    || typeToConvert == typeof(global::Cohere.SummarizeRequestLength)

                    || typeToConvert == typeof(global::Cohere.SummarizeRequestLength?)

                    || typeToConvert == typeof(global::Cohere.SummarizeRequestFormat)

                    || typeToConvert == typeof(global::Cohere.SummarizeRequestFormat?)

                    || typeToConvert == typeof(global::Cohere.SummarizeRequestExtractiveness)

                    || typeToConvert == typeof(global::Cohere.SummarizeRequestExtractiveness?)

                    || typeToConvert == typeof(global::Cohere.ChatAccepts)

                    || typeToConvert == typeof(global::Cohere.ChatAccepts?)

                    || typeToConvert == typeof(global::Cohere.EmbedResponseDiscriminatorResponseType)

                    || typeToConvert == typeof(global::Cohere.EmbedResponseDiscriminatorResponseType?)

                    || typeToConvert == typeof(global::Cohere.ClassifyResponseClassificationClassificationType)

                    || typeToConvert == typeof(global::Cohere.ClassifyResponseClassificationClassificationType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Cohere.ChatRole))
                {
                    return new global::Cohere.JsonConverters.ChatRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatRole?))
                {
                    return new global::Cohere.JsonConverters.ChatRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.MessageDiscriminatorRole))
                {
                    return new global::Cohere.JsonConverters.MessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.MessageDiscriminatorRole?))
                {
                    return new global::Cohere.JsonConverters.MessageDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ResponseFormatType))
                {
                    return new global::Cohere.JsonConverters.ResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ResponseFormatType?))
                {
                    return new global::Cohere.JsonConverters.ResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ResponseFormatDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.ResponseFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ResponseFormatDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.ResponseFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatCitationType))
                {
                    return new global::Cohere.JsonConverters.ChatCitationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatCitationType?))
                {
                    return new global::Cohere.JsonConverters.ChatCitationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.FinishReason))
                {
                    return new global::Cohere.JsonConverters.FinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.FinishReason?))
                {
                    return new global::Cohere.JsonConverters.FinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatStreamEventEventType))
                {
                    return new global::Cohere.JsonConverters.ChatStreamEventEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatStreamEventEventType?))
                {
                    return new global::Cohere.JsonConverters.ChatStreamEventEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatStreamEndEventFinishReason))
                {
                    return new global::Cohere.JsonConverters.ChatStreamEndEventFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatStreamEndEventFinishReason?))
                {
                    return new global::Cohere.JsonConverters.ChatStreamEndEventFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.StreamedChatResponseDiscriminatorEventType))
                {
                    return new global::Cohere.JsonConverters.StreamedChatResponseDiscriminatorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.StreamedChatResponseDiscriminatorEventType?))
                {
                    return new global::Cohere.JsonConverters.StreamedChatResponseDiscriminatorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatTextContentType))
                {
                    return new global::Cohere.JsonConverters.ChatTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatTextContentType?))
                {
                    return new global::Cohere.JsonConverters.ChatTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ContentType))
                {
                    return new global::Cohere.JsonConverters.ContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ContentType?))
                {
                    return new global::Cohere.JsonConverters.ContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ImageUrlDetail))
                {
                    return new global::Cohere.JsonConverters.ImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ImageUrlDetail?))
                {
                    return new global::Cohere.JsonConverters.ImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ContentDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.ContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ContentDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.ContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.UserMessageV2Role))
                {
                    return new global::Cohere.JsonConverters.UserMessageV2RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.UserMessageV2Role?))
                {
                    return new global::Cohere.JsonConverters.UserMessageV2RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ToolCallV2Type))
                {
                    return new global::Cohere.JsonConverters.ToolCallV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ToolCallV2Type?))
                {
                    return new global::Cohere.JsonConverters.ToolCallV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatThinkingContentType))
                {
                    return new global::Cohere.JsonConverters.ChatThinkingContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatThinkingContentType?))
                {
                    return new global::Cohere.JsonConverters.ChatThinkingContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SourceDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.SourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SourceDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.SourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.CitationType))
                {
                    return new global::Cohere.JsonConverters.CitationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.CitationType?))
                {
                    return new global::Cohere.JsonConverters.CitationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AssistantMessageRole))
                {
                    return new global::Cohere.JsonConverters.AssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AssistantMessageRole?))
                {
                    return new global::Cohere.JsonConverters.AssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.AssistantMessageV2ContentOneItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.AssistantMessageV2ContentOneItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SystemMessageV2Role))
                {
                    return new global::Cohere.JsonConverters.SystemMessageV2RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SystemMessageV2Role?))
                {
                    return new global::Cohere.JsonConverters.SystemMessageV2RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.SystemMessageV2ContentVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.SystemMessageV2ContentVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.DocumentContentType))
                {
                    return new global::Cohere.JsonConverters.DocumentContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.DocumentContentType?))
                {
                    return new global::Cohere.JsonConverters.DocumentContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ToolContentDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.ToolContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ToolContentDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.ToolContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ToolMessageV2Role))
                {
                    return new global::Cohere.JsonConverters.ToolMessageV2RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ToolMessageV2Role?))
                {
                    return new global::Cohere.JsonConverters.ToolMessageV2RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatMessageV2DiscriminatorRole))
                {
                    return new global::Cohere.JsonConverters.ChatMessageV2DiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatMessageV2DiscriminatorRole?))
                {
                    return new global::Cohere.JsonConverters.ChatMessageV2DiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ToolV2Type))
                {
                    return new global::Cohere.JsonConverters.ToolV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ToolV2Type?))
                {
                    return new global::Cohere.JsonConverters.ToolV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.CitationOptionsMode))
                {
                    return new global::Cohere.JsonConverters.CitationOptionsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.CitationOptionsMode?))
                {
                    return new global::Cohere.JsonConverters.CitationOptionsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ResponseFormatTypeV2))
                {
                    return new global::Cohere.JsonConverters.ResponseFormatTypeV2JsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ResponseFormatTypeV2?))
                {
                    return new global::Cohere.JsonConverters.ResponseFormatTypeV2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ResponseFormatV2DiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.ResponseFormatV2DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ResponseFormatV2DiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.ResponseFormatV2DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ThinkingType))
                {
                    return new global::Cohere.JsonConverters.ThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ThinkingType?))
                {
                    return new global::Cohere.JsonConverters.ThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatFinishReason))
                {
                    return new global::Cohere.JsonConverters.ChatFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatFinishReason?))
                {
                    return new global::Cohere.JsonConverters.ChatFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AssistantMessageResponseRole))
                {
                    return new global::Cohere.JsonConverters.AssistantMessageResponseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AssistantMessageResponseRole?))
                {
                    return new global::Cohere.JsonConverters.AssistantMessageResponseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.AssistantMessageResponseContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.AssistantMessageResponseContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatStreamEventTypeType))
                {
                    return new global::Cohere.JsonConverters.ChatStreamEventTypeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatStreamEventTypeType?))
                {
                    return new global::Cohere.JsonConverters.ChatStreamEventTypeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatMessageStartEventDeltaMessageRole))
                {
                    return new global::Cohere.JsonConverters.ChatMessageStartEventDeltaMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatMessageStartEventDeltaMessageRole?))
                {
                    return new global::Cohere.JsonConverters.ChatMessageStartEventDeltaMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatContentStartEventDeltaMessageContentType))
                {
                    return new global::Cohere.JsonConverters.ChatContentStartEventDeltaMessageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatContentStartEventDeltaMessageContentType?))
                {
                    return new global::Cohere.JsonConverters.ChatContentStartEventDeltaMessageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.StreamedChatResponseV2DiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.StreamedChatResponseV2DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.StreamedChatResponseV2DiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.StreamedChatResponseV2DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseDocumentType))
                {
                    return new global::Cohere.JsonConverters.ParseDocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseDocumentType?))
                {
                    return new global::Cohere.JsonConverters.ParseDocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseOutputFormat))
                {
                    return new global::Cohere.JsonConverters.ParseOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseOutputFormat?))
                {
                    return new global::Cohere.JsonConverters.ParseOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseTextContentBlockType))
                {
                    return new global::Cohere.JsonConverters.ParseTextContentBlockTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseTextContentBlockType?))
                {
                    return new global::Cohere.JsonConverters.ParseTextContentBlockTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseImageCategory))
                {
                    return new global::Cohere.JsonConverters.ParseImageCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseImageCategory?))
                {
                    return new global::Cohere.JsonConverters.ParseImageCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseImageContentBlockType))
                {
                    return new global::Cohere.JsonConverters.ParseImageContentBlockTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseImageContentBlockType?))
                {
                    return new global::Cohere.JsonConverters.ParseImageContentBlockTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseTableContentType))
                {
                    return new global::Cohere.JsonConverters.ParseTableContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseTableContentType?))
                {
                    return new global::Cohere.JsonConverters.ParseTableContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseTableContentBlockType))
                {
                    return new global::Cohere.JsonConverters.ParseTableContentBlockTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseTableContentBlockType?))
                {
                    return new global::Cohere.JsonConverters.ParseTableContentBlockTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseBlockDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.ParseBlockDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseBlockDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.ParseBlockDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseBlocksPageVariantType))
                {
                    return new global::Cohere.JsonConverters.ParseBlocksPageVariantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseBlocksPageVariantType?))
                {
                    return new global::Cohere.JsonConverters.ParseBlocksPageVariantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseMarkdownPageVariantType))
                {
                    return new global::Cohere.JsonConverters.ParseMarkdownPageVariantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParseMarkdownPageVariantType?))
                {
                    return new global::Cohere.JsonConverters.ParseMarkdownPageVariantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParsePageDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.ParsePageDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ParsePageDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.ParsePageDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GenerateStreamEventEventType))
                {
                    return new global::Cohere.JsonConverters.GenerateStreamEventEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GenerateStreamEventEventType?))
                {
                    return new global::Cohere.JsonConverters.GenerateStreamEventEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GenerateStreamedResponseDiscriminatorEventType))
                {
                    return new global::Cohere.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GenerateStreamedResponseDiscriminatorEventType?))
                {
                    return new global::Cohere.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedInputType))
                {
                    return new global::Cohere.JsonConverters.EmbedInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedInputType?))
                {
                    return new global::Cohere.JsonConverters.EmbedInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbeddingType))
                {
                    return new global::Cohere.JsonConverters.EmbeddingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbeddingType?))
                {
                    return new global::Cohere.JsonConverters.EmbeddingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedFloatsResponseResponseType))
                {
                    return new global::Cohere.JsonConverters.EmbedFloatsResponseResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedFloatsResponseResponseType?))
                {
                    return new global::Cohere.JsonConverters.EmbedFloatsResponseResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedByTypeResponseResponseType))
                {
                    return new global::Cohere.JsonConverters.EmbedByTypeResponseResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedByTypeResponseResponseType?))
                {
                    return new global::Cohere.JsonConverters.EmbedByTypeResponseResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedContentType))
                {
                    return new global::Cohere.JsonConverters.EmbedContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedContentType?))
                {
                    return new global::Cohere.JsonConverters.EmbedContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedContentDiscriminatorType))
                {
                    return new global::Cohere.JsonConverters.EmbedContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedContentDiscriminatorType?))
                {
                    return new global::Cohere.JsonConverters.EmbedContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.BatchStatus))
                {
                    return new global::Cohere.JsonConverters.BatchStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.BatchStatus?))
                {
                    return new global::Cohere.JsonConverters.BatchStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedJobStatus))
                {
                    return new global::Cohere.JsonConverters.EmbedJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedJobStatus?))
                {
                    return new global::Cohere.JsonConverters.EmbedJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedJobTruncate))
                {
                    return new global::Cohere.JsonConverters.EmbedJobTruncateJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedJobTruncate?))
                {
                    return new global::Cohere.JsonConverters.EmbedJobTruncateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.CreateEmbedJobRequestTruncate))
                {
                    return new global::Cohere.JsonConverters.CreateEmbedJobRequestTruncateJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.CreateEmbedJobRequestTruncate?))
                {
                    return new global::Cohere.JsonConverters.CreateEmbedJobRequestTruncateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.DatasetValidationStatus))
                {
                    return new global::Cohere.JsonConverters.DatasetValidationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.DatasetValidationStatus?))
                {
                    return new global::Cohere.JsonConverters.DatasetValidationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.DatasetType))
                {
                    return new global::Cohere.JsonConverters.DatasetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.DatasetType?))
                {
                    return new global::Cohere.JsonConverters.DatasetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ConnectorAuthStatus))
                {
                    return new global::Cohere.JsonConverters.ConnectorAuthStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ConnectorAuthStatus?))
                {
                    return new global::Cohere.JsonConverters.ConnectorAuthStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AuthTokenType))
                {
                    return new global::Cohere.JsonConverters.AuthTokenTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.AuthTokenType?))
                {
                    return new global::Cohere.JsonConverters.AuthTokenTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GetClusterJobResponseStatus))
                {
                    return new global::Cohere.JsonConverters.GetClusterJobResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GetClusterJobResponseStatus?))
                {
                    return new global::Cohere.JsonConverters.GetClusterJobResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.UpdateClusterJobRequestStatus))
                {
                    return new global::Cohere.JsonConverters.UpdateClusterJobRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.UpdateClusterJobRequestStatus?))
                {
                    return new global::Cohere.JsonConverters.UpdateClusterJobRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.CompatibleEndpoint))
                {
                    return new global::Cohere.JsonConverters.CompatibleEndpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.CompatibleEndpoint?))
                {
                    return new global::Cohere.JsonConverters.CompatibleEndpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.BaseType))
                {
                    return new global::Cohere.JsonConverters.BaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.BaseType?))
                {
                    return new global::Cohere.JsonConverters.BaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.Strategy))
                {
                    return new global::Cohere.JsonConverters.StrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.Strategy?))
                {
                    return new global::Cohere.JsonConverters.StrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.LoraTargetModules))
                {
                    return new global::Cohere.JsonConverters.LoraTargetModulesJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.LoraTargetModules?))
                {
                    return new global::Cohere.JsonConverters.LoraTargetModulesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.Status))
                {
                    return new global::Cohere.JsonConverters.StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.Status?))
                {
                    return new global::Cohere.JsonConverters.StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatRequestPromptTruncation))
                {
                    return new global::Cohere.JsonConverters.ChatRequestPromptTruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatRequestPromptTruncation?))
                {
                    return new global::Cohere.JsonConverters.ChatRequestPromptTruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatRequestCitationQuality))
                {
                    return new global::Cohere.JsonConverters.ChatRequestCitationQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatRequestCitationQuality?))
                {
                    return new global::Cohere.JsonConverters.ChatRequestCitationQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatRequestSafetyMode))
                {
                    return new global::Cohere.JsonConverters.ChatRequestSafetyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatRequestSafetyMode?))
                {
                    return new global::Cohere.JsonConverters.ChatRequestSafetyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.Chatv2RequestSafetyMode))
                {
                    return new global::Cohere.JsonConverters.Chatv2RequestSafetyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.Chatv2RequestSafetyMode?))
                {
                    return new global::Cohere.JsonConverters.Chatv2RequestSafetyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.Chatv2RequestToolChoice))
                {
                    return new global::Cohere.JsonConverters.Chatv2RequestToolChoiceJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.Chatv2RequestToolChoice?))
                {
                    return new global::Cohere.JsonConverters.Chatv2RequestToolChoiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GenerateRequestTruncate))
                {
                    return new global::Cohere.JsonConverters.GenerateRequestTruncateJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GenerateRequestTruncate?))
                {
                    return new global::Cohere.JsonConverters.GenerateRequestTruncateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GenerateRequestReturnLikelihoods))
                {
                    return new global::Cohere.JsonConverters.GenerateRequestReturnLikelihoodsJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.GenerateRequestReturnLikelihoods?))
                {
                    return new global::Cohere.JsonConverters.GenerateRequestReturnLikelihoodsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedRequestTruncate))
                {
                    return new global::Cohere.JsonConverters.EmbedRequestTruncateJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedRequestTruncate?))
                {
                    return new global::Cohere.JsonConverters.EmbedRequestTruncateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.V2EmbedRequestTruncate))
                {
                    return new global::Cohere.JsonConverters.V2EmbedRequestTruncateJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.V2EmbedRequestTruncate?))
                {
                    return new global::Cohere.JsonConverters.V2EmbedRequestTruncateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ClassifyRequestTruncate))
                {
                    return new global::Cohere.JsonConverters.ClassifyRequestTruncateJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ClassifyRequestTruncate?))
                {
                    return new global::Cohere.JsonConverters.ClassifyRequestTruncateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SummarizeRequestLength))
                {
                    return new global::Cohere.JsonConverters.SummarizeRequestLengthJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SummarizeRequestLength?))
                {
                    return new global::Cohere.JsonConverters.SummarizeRequestLengthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SummarizeRequestFormat))
                {
                    return new global::Cohere.JsonConverters.SummarizeRequestFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SummarizeRequestFormat?))
                {
                    return new global::Cohere.JsonConverters.SummarizeRequestFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SummarizeRequestExtractiveness))
                {
                    return new global::Cohere.JsonConverters.SummarizeRequestExtractivenessJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.SummarizeRequestExtractiveness?))
                {
                    return new global::Cohere.JsonConverters.SummarizeRequestExtractivenessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatAccepts))
                {
                    return new global::Cohere.JsonConverters.ChatAcceptsJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ChatAccepts?))
                {
                    return new global::Cohere.JsonConverters.ChatAcceptsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedResponseDiscriminatorResponseType))
                {
                    return new global::Cohere.JsonConverters.EmbedResponseDiscriminatorResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.EmbedResponseDiscriminatorResponseType?))
                {
                    return new global::Cohere.JsonConverters.EmbedResponseDiscriminatorResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ClassifyResponseClassificationClassificationType))
                {
                    return new global::Cohere.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Cohere.ClassifyResponseClassificationClassificationType?))
                {
                    return new global::Cohere.JsonConverters.ClassifyResponseClassificationClassificationTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}