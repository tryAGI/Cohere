
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
            typeof(global::Cohere.JsonConverters.CitationTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.CitationTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.TextContentTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.TextContentTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.AssistantMessageContentVariant2ItemDiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.AssistantMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.AssistantMessageRoleJsonConverter),
            typeof(global::Cohere.JsonConverters.AssistantMessageRoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ToolCallV2TypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ToolCallV2TypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.AssistantMessageResponseContentItemDiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.AssistantMessageResponseContentItemDiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.AssistantMessageResponseRoleJsonConverter),
            typeof(global::Cohere.JsonConverters.AssistantMessageResponseRoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.AuthTokenTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.AuthTokenTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.BaseTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.BaseTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.StrategyJsonConverter),
            typeof(global::Cohere.JsonConverters.StrategyNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatCitationTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatCitationTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatStreamEventEventTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatStreamEventEventTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatStreamEventTypeTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatStreamEventTypeTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatFinishReasonJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatFinishReasonNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatRoleJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatRoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ContentTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ContentTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ContentDiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ContentDiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.UserMessageRoleJsonConverter),
            typeof(global::Cohere.JsonConverters.UserMessageRoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.SystemMessageContentVariant2ItemDiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.SystemMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.SystemMessageRoleJsonConverter),
            typeof(global::Cohere.JsonConverters.SystemMessageRoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.DocumentContentTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.DocumentContentTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ToolContentDiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ToolContentDiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ToolMessageV2RoleJsonConverter),
            typeof(global::Cohere.JsonConverters.ToolMessageV2RoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatMessageV2DiscriminatorRoleJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatMessageV2DiscriminatorRoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatStreamEndEventVariant2FinishReasonJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatStreamEndEventVariant2FinishReasonNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.MessageDiscriminatorRoleJsonConverter),
            typeof(global::Cohere.JsonConverters.MessageDiscriminatorRoleNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.FinishReasonJsonConverter),
            typeof(global::Cohere.JsonConverters.FinishReasonNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.CitationOptionsModeJsonConverter),
            typeof(global::Cohere.JsonConverters.CitationOptionsModeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.CompatibleEndpointJsonConverter),
            typeof(global::Cohere.JsonConverters.CompatibleEndpointNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ConnectorAuthStatusJsonConverter),
            typeof(global::Cohere.JsonConverters.ConnectorAuthStatusNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbeddingTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbeddingTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedInputTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedInputTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.CreateEmbedJobRequestTruncateJsonConverter),
            typeof(global::Cohere.JsonConverters.CreateEmbedJobRequestTruncateNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.LoraTargetModulesJsonConverter),
            typeof(global::Cohere.JsonConverters.LoraTargetModulesNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.StatusJsonConverter),
            typeof(global::Cohere.JsonConverters.StatusNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.DatasetTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.DatasetTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.DatasetValidationStatusJsonConverter),
            typeof(global::Cohere.JsonConverters.DatasetValidationStatusNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedByTypeResponseResponseTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedByTypeResponseResponseTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedContentTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedContentTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedContentDiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedContentDiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedFloatsResponseResponseTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedFloatsResponseResponseTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedJobStatusJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedJobStatusNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedJobTruncateJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedJobTruncateNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateStreamEventEventTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateStreamEventEventTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.GetClusterJobResponseStatusJsonConverter),
            typeof(global::Cohere.JsonConverters.GetClusterJobResponseStatusNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatTypeV2JsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatTypeV2NullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ReasoningEffortJsonConverter),
            typeof(global::Cohere.JsonConverters.ReasoningEffortNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatDiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatDiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatV2DiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatV2DiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.StreamedChatResponseDiscriminatorEventTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.StreamedChatResponseDiscriminatorEventTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.StreamedChatResponseV2DiscriminatorTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.StreamedChatResponseV2DiscriminatorTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ToolV2TypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ToolV2TypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.UpdateClusterJobRequestStatusJsonConverter),
            typeof(global::Cohere.JsonConverters.UpdateClusterJobRequestStatusNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatRequestCitationQualityJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatRequestCitationQualityNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatRequestPromptTruncationJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatRequestPromptTruncationNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatRequestSafetyModeJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatRequestSafetyModeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ClassifyRequestTruncateJsonConverter),
            typeof(global::Cohere.JsonConverters.ClassifyRequestTruncateNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedRequestTruncateJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedRequestTruncateNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateRequestReturnLikelihoodsJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateRequestReturnLikelihoodsNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateRequestTruncateJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateRequestTruncateNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.SummarizeRequestExtractivenessJsonConverter),
            typeof(global::Cohere.JsonConverters.SummarizeRequestExtractivenessNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.SummarizeRequestFormatJsonConverter),
            typeof(global::Cohere.JsonConverters.SummarizeRequestFormatNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.SummarizeRequestLengthJsonConverter),
            typeof(global::Cohere.JsonConverters.SummarizeRequestLengthNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.Chatv2RequestSafetyModeJsonConverter),
            typeof(global::Cohere.JsonConverters.Chatv2RequestSafetyModeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.Chatv2RequestToolChoiceJsonConverter),
            typeof(global::Cohere.JsonConverters.Chatv2RequestToolChoiceNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.Embedv2RequestTruncateJsonConverter),
            typeof(global::Cohere.JsonConverters.Embedv2RequestTruncateNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatAcceptsJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatAcceptsNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.ClassifyResponseClassificationClassificationTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedResponseDiscriminatorResponseTypeJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedResponseDiscriminatorResponseTypeNullableJsonConverter),
            typeof(global::Cohere.JsonConverters.SourceJsonConverter),
            typeof(global::Cohere.JsonConverters.ContentVariant2ItemJsonConverter),
            typeof(global::Cohere.JsonConverters.ContentItemJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatCitationGenerationEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatContentDeltaEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatContentEndEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatContentStartEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatDebugEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatMessageEndEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatMessageStartEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatMessageV2JsonConverter),
            typeof(global::Cohere.JsonConverters.Content2JsonConverter),
            typeof(global::Cohere.JsonConverters.ContentVariant2Item2JsonConverter),
            typeof(global::Cohere.JsonConverters.ToolContentJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatSearchQueriesGenerationEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatSearchResultsEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatStreamEndEventJsonConverter),
            typeof(global::Cohere.JsonConverters.MessageJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatStreamStartEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatTextGenerationEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatToolCallDeltaEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatToolCallEndEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatToolCallStartEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatToolCallsChunkEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatToolCallsGenerationEventJsonConverter),
            typeof(global::Cohere.JsonConverters.ChatToolPlanDeltaEventJsonConverter),
            typeof(global::Cohere.JsonConverters.CitationEndEventJsonConverter),
            typeof(global::Cohere.JsonConverters.CitationStartEventJsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedContentJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateStreamEndJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateStreamErrorJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateStreamTextJsonConverter),
            typeof(global::Cohere.JsonConverters.GenerateStreamedResponseJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatJsonConverter),
            typeof(global::Cohere.JsonConverters.ResponseFormatV2JsonConverter),
            typeof(global::Cohere.JsonConverters.StreamedChatResponseJsonConverter),
            typeof(global::Cohere.JsonConverters.StreamedChatResponseV2JsonConverter),
            typeof(global::Cohere.JsonConverters.EmbedResponseJsonConverter),
            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>>),
            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.Content2>>),
            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>>),
            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>>),
            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::Cohere.RerankDocument>),
            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::Cohere.Document>),
            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>),
            typeof(global::Cohere.JsonConverters.OneOfJsonConverter<global::Cohere.ChatResponse, global::Cohere.StreamedChatResponseV2?>),
            typeof(global::Cohere.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Cohere.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}