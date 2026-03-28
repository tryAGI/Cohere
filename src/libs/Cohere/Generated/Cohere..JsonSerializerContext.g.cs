
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
            typeof(global::Cohere.JsonConverters.ChatRoleJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatRoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.MessageDiscriminatorRoleJsonConverter),

            typeof(global::Cohere.JsonConverters.MessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatCitationTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatCitationTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.FinishReasonJsonConverter),

            typeof(global::Cohere.JsonConverters.FinishReasonNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamEventEventTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamEventEventTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamEndEventY8gq2xFinishReasonJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamEndEventY8gq2xFinishReasonNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.StreamedChatResponseDiscriminatorEventTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.StreamedChatResponseDiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatTextContentTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatTextContentTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ContentTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ContentTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ImageUrlDetailJsonConverter),

            typeof(global::Cohere.JsonConverters.ImageUrlDetailNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ContentDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ContentDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.UserMessageV2RoleJsonConverter),

            typeof(global::Cohere.JsonConverters.UserMessageV2RoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ToolCallV2TypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ToolCallV2TypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatThinkingContentTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatThinkingContentTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.SourceDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.SourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.CitationTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.CitationTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageRoleJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageRoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageContentVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.SystemMessageV2RoleJsonConverter),

            typeof(global::Cohere.JsonConverters.SystemMessageV2RoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.SystemMessageV2ContentVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.SystemMessageV2ContentVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.DocumentContentTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.DocumentContentTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ToolContentDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ToolContentDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ToolMessageV2RoleJsonConverter),

            typeof(global::Cohere.JsonConverters.ToolMessageV2RoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatMessageV2DiscriminatorRoleJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatMessageV2DiscriminatorRoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ToolV2TypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ToolV2TypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.CitationOptionsModeJsonConverter),

            typeof(global::Cohere.JsonConverters.CitationOptionsModeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatTypeV2JsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatTypeV2NullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatV2DiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatV2DiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ThinkingTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ThinkingTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatFinishReasonJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatFinishReasonNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageResponseRoleJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageResponseRoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageResponseContentItemDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageResponseContentItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamEventTypeTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamEventTypeTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatMessageStartEventDeltaMessageRoleJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatMessageStartEventDeltaMessageRoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatContentStartEventDeltaMessageContentTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatContentStartEventDeltaMessageContentTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.StreamedChatResponseV2DiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.StreamedChatResponseV2DiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateStreamEventEventTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateStreamEventEventTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedInputTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedInputTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbeddingTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbeddingTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedFloatsResponseResponseTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedFloatsResponseResponseTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedByTypeResponseResponseTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedByTypeResponseResponseTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedContentTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedContentTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedContentDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedContentDiscriminatorTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.BatchStatusJsonConverter),

            typeof(global::Cohere.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedJobStatusJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedJobStatusNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedJobTruncateJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedJobTruncateNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.CreateEmbedJobRequestTruncateJsonConverter),

            typeof(global::Cohere.JsonConverters.CreateEmbedJobRequestTruncateNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.DatasetValidationStatusJsonConverter),

            typeof(global::Cohere.JsonConverters.DatasetValidationStatusNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.DatasetTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.DatasetTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ConnectorAuthStatusJsonConverter),

            typeof(global::Cohere.JsonConverters.ConnectorAuthStatusNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.AuthTokenTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.AuthTokenTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.GetClusterJobResponseStatusJsonConverter),

            typeof(global::Cohere.JsonConverters.GetClusterJobResponseStatusNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.UpdateClusterJobRequestStatusJsonConverter),

            typeof(global::Cohere.JsonConverters.UpdateClusterJobRequestStatusNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.CompatibleEndpointJsonConverter),

            typeof(global::Cohere.JsonConverters.CompatibleEndpointNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.BaseTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.BaseTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.StrategyJsonConverter),

            typeof(global::Cohere.JsonConverters.StrategyNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.LoraTargetModulesJsonConverter),

            typeof(global::Cohere.JsonConverters.LoraTargetModulesNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.StatusJsonConverter),

            typeof(global::Cohere.JsonConverters.StatusNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatRequestPromptTruncationJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatRequestPromptTruncationNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatRequestCitationQualityJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatRequestCitationQualityNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatRequestSafetyModeJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatRequestSafetyModeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.Chatv2RequestSafetyModeJsonConverter),

            typeof(global::Cohere.JsonConverters.Chatv2RequestSafetyModeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.Chatv2RequestToolChoiceJsonConverter),

            typeof(global::Cohere.JsonConverters.Chatv2RequestToolChoiceNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateRequestTruncateJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateRequestTruncateNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateRequestReturnLikelihoodsJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateRequestReturnLikelihoodsNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedRequestTruncateJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedRequestTruncateNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.V2EmbedRequestTruncateJsonConverter),

            typeof(global::Cohere.JsonConverters.V2EmbedRequestTruncateNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ClassifyRequestTruncateJsonConverter),

            typeof(global::Cohere.JsonConverters.ClassifyRequestTruncateNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.SummarizeRequestLengthJsonConverter),

            typeof(global::Cohere.JsonConverters.SummarizeRequestLengthNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.SummarizeRequestFormatJsonConverter),

            typeof(global::Cohere.JsonConverters.SummarizeRequestFormatNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.SummarizeRequestExtractivenessJsonConverter),

            typeof(global::Cohere.JsonConverters.SummarizeRequestExtractivenessNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatAcceptsJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatAcceptsNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedResponseDiscriminatorResponseTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedResponseDiscriminatorResponseTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ClassifyResponseClassificationClassificationTypeNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.MessageJsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamStartEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatSearchQueriesGenerationEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatSearchResultsEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatTextGenerationEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatCitationGenerationEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatToolCallsGenerationEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamEndEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatToolCallsChunkEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatDebugEventJsonConverter),

            typeof(global::Cohere.JsonConverters.StreamedChatResponseJsonConverter),

            typeof(global::Cohere.JsonConverters.ContentJsonConverter),

            typeof(global::Cohere.JsonConverters.SourceJsonConverter),

            typeof(global::Cohere.JsonConverters.ContentVariant2ItemJsonConverter),

            typeof(global::Cohere.JsonConverters.ContentVariant2Item2JsonConverter),

            typeof(global::Cohere.JsonConverters.ToolContentJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatMessageV2JsonConverter),

            typeof(global::Cohere.JsonConverters.ResponseFormatV2JsonConverter),

            typeof(global::Cohere.JsonConverters.ContentItemJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatMessageStartEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatContentStartEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatContentDeltaEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatContentEndEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatToolPlanDeltaEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatToolCallStartEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatToolCallDeltaEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatToolCallEndEventJsonConverter),

            typeof(global::Cohere.JsonConverters.CitationStartEventJsonConverter),

            typeof(global::Cohere.JsonConverters.CitationEndEventJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatMessageEndEventJsonConverter),

            typeof(global::Cohere.JsonConverters.StreamedChatResponseV2JsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateStreamTextJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateStreamEndJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateStreamErrorJsonConverter),

            typeof(global::Cohere.JsonConverters.GenerateStreamedResponseJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedContentJsonConverter),

            typeof(global::Cohere.JsonConverters.EmbedResponseJsonConverter),

            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.Content>>),

            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>>),

            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>>),

            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>>),

            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::Cohere.Document>),

            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::Cohere.RerankDocument>),

            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>),

            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<global::Cohere.ChatResponseV2, global::Cohere.StreamedChatResponseV2?>),

            typeof(global::Cohere.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.MessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.MessageDiscriminatorRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cohere.ToolParameterDefinitionsValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolParameterDefinitionsValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.JSONResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.FinishReason))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEventEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamStartEvent5v9jyv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQueriesGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQueriesGenerationEvent6evypd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultsEvent44axt5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextGenerationEvent8yyj22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationGenerationEventLg3v2o))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsGenerationEventNykiww))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEventY8gq2x))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEventY8gq2xFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsChunkEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsChunkEventT7lliu))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDebugEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDebugEvent352j0t))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseDiscriminatorEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ImageUrlDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UserMessageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UserMessageV2Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.Content>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Content>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallV2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallV2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatThinkingContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatThinkingContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SourceDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Citation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolCallV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageContentVariant2ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Citation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentVariant2Item2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DocumentContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DocumentContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolContentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolMessageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolMessageV2Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageV2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageV2DiscriminatorRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ChatMessageV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolV2Type))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolV2Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationOptionsMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatTypeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextResponseFormatV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.JsonResponseFormatV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatV2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ResponseFormatV2DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Thinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ThinkingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponseRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminatorType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEventTypeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventLsegeq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventDeltaMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEvent6xvlq1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDeltaMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventDeltaMessageContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEvent3m0vqs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventDeltaMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentEndEventMa278i))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEvent2obfex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventLv559x))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEvent2bxzoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventDeltaMessageToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventDeltaMessageToolCallsFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallEndEventT6ph9s))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventT3df62))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventDeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationEndEventFs3igt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEventU3fzny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEventDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGenerationTokenLikelihoodsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGenerationTokenLikelihoodsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Generation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEventEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamTextYai5v6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGenerationInStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEndUbzr0t))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEndResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGenerationInStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamError49d5xw))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamedResponseDiscriminatorEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedInputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbeddingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedFloatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedFloatsResponseResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedByTypeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedByTypeResponseResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedByTypeResponseEmbeddings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedContentDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BatchStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BatchError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RetryBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedJobTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbedJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbeddingType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobRequestTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetValidationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ConnectorAuthStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Connector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorOAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AuthTokenType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorServiceAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ConnectorLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorsLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ConnectorLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenLikelihood))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.LogLikelihoodResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.TokenLikelihood>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Cluster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetClusterJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetClusterJobResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Cluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListClusterJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.GetClusterJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateClusterJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateClusterJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateClusterJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateClusterJobRequestStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateClusterJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CompatibleEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.CompatibleEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.GetModelResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BaseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Strategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BaseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.LoraTargetModules))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Hyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.WandbConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Settings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.FinetunedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListFinetunedModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.FinetunedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateFinetunedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetFinetunedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateFinetunedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TrainingStepMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListTrainingStepMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.TrainingStepMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestPromptTruncation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ChatConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestCitationQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatRequestSafetyMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.Document>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::Cohere.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2RequestSafetyMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2RequestToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateRequestTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateRequestReturnLikelihoods))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedRequestTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2EmbedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbedInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2EmbedRequestTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AudioTranscriptionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.RerankDocument>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::Cohere.RerankDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ClassifyExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyRequestTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetDytngn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestLength))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestExtractiveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateFinetunedModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatAccepts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<global::Cohere.ChatResponseV2, global::Cohere.StreamedChatResponseV2?>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponseDiscriminatorResponseType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AudioTranscriptionsCreateResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.NotFoundErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.BadRequestErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnauthorizedErrorBody14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UnprocessableEntityErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GatewayTimeoutErrorBody7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ForbiddenErrorBody7))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.RerankResponseResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponseResultsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponseResultsItemDocument))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2RerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.V2RerankResponseResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.V2RerankResponseResultsItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ClassifyResponseClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cohere.ClassifyResponseClassificationLabels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassificationLabels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassificationClassificationType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetsCreateResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Dataset>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetsGetUsageResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DatasetsGetResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckApiKeyResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
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
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}