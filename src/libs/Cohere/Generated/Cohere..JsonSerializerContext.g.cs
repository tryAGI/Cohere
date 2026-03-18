
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

            typeof(global::Cohere.JsonConverters.ChatStreamEndEventVariant2FinishReasonJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatStreamEndEventVariant2FinishReasonNullableJsonConverter),

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

            typeof(global::Cohere.JsonConverters.AssistantMessageV2RoleJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageV2RoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageV2ContentVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.AssistantMessageV2ContentVariant2ItemDiscriminatorTypeNullableJsonConverter),

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

            typeof(global::Cohere.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleNullableJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeJsonConverter),

            typeof(global::Cohere.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeNullableJsonConverter),

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

            typeof(global::Cohere.JsonConverters.Embedv2RequestTruncateJsonConverter),

            typeof(global::Cohere.JsonConverters.Embedv2RequestTruncateNullableJsonConverter),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cohere.ToolParameterDefinitions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolParameterDefinitions2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamStartEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQueriesGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchQueriesGenerationEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatSearchResultsEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatTextGenerationEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatCitationGenerationEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsGenerationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsGenerationEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatStreamEndEventVariant2FinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsChunkEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallsChunkEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDebugEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatDebugEventVariant2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageV2Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ToolCallV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageV2ContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.AssistantMessageV2ContentVariant2ItemDiscriminatorType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventVariant2Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventVariant2DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageStartEventVariant2DeltaMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventVariant2Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventVariant2DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventVariant2DeltaMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentStartEventVariant2DeltaMessageContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventVariant2Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventVariant2DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentDeltaEventVariant2DeltaMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatContentEndEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEventVariant2Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolPlanDeltaEventVariant2DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventVariant2Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallStartEventVariant2DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventVariant2Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventVariant2DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventVariant2DeltaMessageToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallDeltaEventVariant2DeltaMessageToolCallsFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatToolCallEndEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventVariant2Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationStartEventVariant2DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CitationEndEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatMessageEndEventVariant2Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.StreamedChatResponseV2DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGenerationTokenLikelihood>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGenerationTokenLikelihood))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Generation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGeneration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEventEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamTextVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SingleGenerationInStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEndVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamEndVariant2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.SingleGenerationInStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateStreamErrorVariant2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.EmbedInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2RequestTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.RerankDocument>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<string, global::Cohere.RerankDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ClassifyExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyRequestTruncate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestLength))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeRequestExtractiveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateFinetunedModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatAccepts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ChatResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OneOf<global::Cohere.ChatResponseV2, global::Cohere.StreamedChatResponseV2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Chatv2Response13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GenerateResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponseDiscriminatorResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.EmbedResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Embedv2Response12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateEmbedJobResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListEmbedJobsResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetEmbedJobResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CancelEmbedJobResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.RerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponseResultDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.RerankResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Rerankv2ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2ResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.Rerankv2Response13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.ClassifyResponseClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Cohere.ClassifyResponseClassificationLabels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassificationLabels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponseClassificationClassificationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ClassifyResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateDatasetResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Cohere.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListDatasetsResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetUsageResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetDatasetResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteDatasetResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.SummarizeResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.TokenizeResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DetokenizeResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListConnectorsResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CreateConnectorResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetConnectorResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.UpdateConnectorResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.DeleteConnectorResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.OAuthAuthorizeConnectorResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.GetModelResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.ListModelsResponse13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.CheckAPIKeyResponse13))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.SingleGenerationTokenLikelihood>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.RerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Rerankv2ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.ClassifyResponseClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Cohere.Dataset>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}