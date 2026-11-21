
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatRole? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolCall? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessage? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ToolCall>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolResult? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolMessage? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ToolResult>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Message? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.MessageDiscriminator? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.MessageDiscriminatorRole? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatConnector? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatDocument? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Tool? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cohere.ToolParameterDefinitionsValue>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolParameterDefinitionsValue? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ResponseFormatType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatTextResponseFormat? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.JSONResponseFormat? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ResponseFormat? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ResponseFormatDiscriminator? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ResponseFormatDiscriminatorType? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatCitation? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatCitationType? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchQuery? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchResultConnector? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchResult? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.FinishReason? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ApiMeta? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ApiMetaApiVersion? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ApiMetaBilledUnits? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ApiMetaTokens? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.NonStreamedChatResponse? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ChatCitation>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ChatDocument>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ChatSearchQuery>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ChatSearchResult>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Message>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamEvent? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamEventEventType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamStartEvent? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamStartEvent5v9jyv? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchQueriesGenerationEvent? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchQueriesGenerationEvent6evypd? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchResultsEvent? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchResultsEvent44axt5? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatTextGenerationEvent? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatTextGenerationEvent8yyj22? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatCitationGenerationEvent? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatCitationGenerationEventLg3v2o? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallsGenerationEvent? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallsGenerationEventNykiww? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamEndEvent? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamEndEventY8gq2x? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamEndEventFinishReason? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolCallDelta? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallsChunkEvent? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallsChunkEventT7lliu? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatDebugEvent? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatDebugEvent352j0t? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.StreamedChatResponse? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.StreamedChatResponseDiscriminator? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.StreamedChatResponseDiscriminatorEventType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatTextContent? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatTextContentType? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ContentType? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ImageUrl? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ImageUrlDetail? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ImageContent? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Content? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ContentDiscriminator? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ContentDiscriminatorType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UserMessageV2? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UserMessageV2Role? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.Content>>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Content>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolCallV2? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolCallV2Type? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolCallV2Function? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatThinkingContent? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatThinkingContentType? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolSource? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatDocumentSource? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Source? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SourceDiscriminator? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SourceDiscriminatorType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Citation? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Source>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AssistantMessage? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AssistantMessageRole? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ToolCallV2>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ContentVariant2Item2? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AssistantMessageV2ContentOneItemDiscriminator? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Citation>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SystemMessageV2? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SystemMessageV2Role? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ContentVariant2Item? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminator? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SystemMessageV2ContentVariant2ItemDiscriminatorType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Document? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DocumentContent? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DocumentContentType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolContent? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolContentDiscriminator? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolContentDiscriminatorType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolMessageV2? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolMessageV2Role? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ToolContent>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageV2? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageV2Discriminator? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageV2DiscriminatorRole? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ChatMessageV2>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolV2? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolV2Type? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolV2Function? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationOptions? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationOptionsMode? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.TruncationStrategy? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ResponseFormatTypeV2? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatTextResponseFormatV2? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.JsonResponseFormatV2? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ResponseFormatV2? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ResponseFormatV2Discriminator? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ResponseFormatV2DiscriminatorType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Thinking? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ThinkingType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatFinishReason? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AssistantMessageResponse? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AssistantMessageResponseRole? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ContentItem>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ContentItem? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AssistantMessageResponseContentItemDiscriminator? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AssistantMessageResponseContentItemDiscriminatorType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Usage? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UsageBilledUnits? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UsageTokens? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.LogprobItem? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatResponseV2? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.LogprobItem>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamEventType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamEventTypeType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageStartEvent? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageStartEventLsegeq? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageStartEventDelta? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageStartEventDeltaMessage? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageStartEventDeltaMessageRole? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentStartEvent? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentStartEvent6xvlq1? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentStartEventDelta? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentStartEventDeltaMessage? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentStartEventDeltaMessageContent? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentStartEventDeltaMessageContentType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentDeltaEvent? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentDeltaEvent3m0vqs? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentDeltaEventDelta? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentDeltaEventDeltaMessage? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentDeltaEventDeltaMessageContent? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentEndEvent? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatContentEndEventMa278i? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolPlanDeltaEvent? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolPlanDeltaEvent2obfex? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolPlanDeltaEventDelta? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolPlanDeltaEventDeltaMessage? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallStartEvent? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallStartEventLv559x? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallStartEventDelta? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallStartEventDeltaMessage? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallDeltaEvent? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallDeltaEvent2bxzoc? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallDeltaEventDelta? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallDeltaEventDeltaMessage? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallDeltaEventDeltaMessageToolCalls? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallDeltaEventDeltaMessageToolCallsFunction? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallEndEvent? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallEndEventT6ph9s? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationStartEvent? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationStartEventT3df62? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationStartEventDelta? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationStartEventDeltaMessage? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationEndEvent? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CitationEndEventFs3igt? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageEndEvent? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageEndEventU3fzny? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatMessageEndEventDelta? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.StreamedChatResponseV2? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.StreamedChatResponseV2Discriminator? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.StreamedChatResponseV2DiscriminatorType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.PromptResponseV2? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseDocument? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseDocumentType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseOutputFormat? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseTextBlock? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseTextContentBlock? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseTextContentBlockType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseImageCategory? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseBoundingBox? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseBoundingBoxNormalized? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseImageBlock? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseImageContentBlock? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseImageContentBlockType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseTableContentType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseTableBlock? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseTableContentBlock? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseTableContentBlockType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseBlock? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseBlockDiscriminator? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseBlockDiscriminatorType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseBlocksPageVariant? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseBlocksPageVariantType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ParseBlock>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseMarkdownPage? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ParseImageBlock>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseMarkdownPageVariant? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseMarkdownPageVariantType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParsePage? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParsePageDiscriminator? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParsePageDiscriminatorType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ParsePage>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SingleGeneration? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.SingleGenerationTokenLikelihoodsItem>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SingleGenerationTokenLikelihoodsItem? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Generation? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.SingleGeneration>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamEvent? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamEventEventType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamText? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamTextYai5v6? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SingleGenerationInStream? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamEnd? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamEndUbzr0t? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamEndResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.SingleGenerationInStream>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamError? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamError49d5xw? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamedResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamedResponseDiscriminator? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateStreamedResponseDiscriminatorEventType? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedInputType? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbeddingType? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Image? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedFloatsResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedFloatsResponseResponseType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Image>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedByTypeResponse? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedByTypeResponseResponseType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedByTypeResponseEmbeddings? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedContentType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedImageUrl? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedImage? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedText? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedContent? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedContentDiscriminator? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedContentDiscriminatorType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedInput? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.EmbedContent>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.BatchStatus? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Batch? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ListBatchesResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Batch>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.BatchError? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateBatchResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GetBatchResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CancelBatchResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RetryBatchResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedJob? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedJobStatus? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedJobTruncate? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ListEmbedJobResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.EmbedJob>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateEmbedJobRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.EmbeddingType>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateEmbedJobRequestTruncate? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateEmbedJobResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankDocument? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankRelevantSpans? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankRelevantSpansMode? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankRelevantSpanResponse? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ClassifyExample? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DatasetValidationStatus? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DatasetType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DatasetPart? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseInfo? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankerDataMetrics? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatDataMetrics? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.LabelMetric? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ClassifyDataMetrics? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.LabelMetric>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.FinetuneDatasetMetrics? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Metrics? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Dataset? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.DatasetPart>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ConnectorOAuth? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Connector? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ConnectorAuthStatus? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ListConnectorsResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Connector>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateConnectorOAuth? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AuthTokenType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateConnectorServiceAuth? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateConnectorRequest? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateConnectorResponse? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GetConnectorResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DeleteConnectorResponse? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UpdateConnectorRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UpdateConnectorResponse? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OAuthAuthorizeResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ConnectorLog? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GetConnectorsLogsResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ConnectorLog>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.FeedbackResponse? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.TokenLikelihood? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.LogLikelihoodResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.TokenLikelihood>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Cluster? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GetClusterJobResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GetClusterJobResponseStatus? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Cluster>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ListClusterJobsResponse? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.GetClusterJobResponse>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateClusterJobRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateClusterJobResponse? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UpdateClusterJobRequest? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UpdateClusterJobRequestStatus? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UpdateClusterJobResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CompatibleEndpoint? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GetModelResponse? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.CompatibleEndpoint>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GetModelResponseSamplingDefaults? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ListModelsResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.GetModelResponse>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.BaseType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Strategy? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.BaseModel? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.LoraTargetModules? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Hyperparameters? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.WandbConfig? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Settings? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Status? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.FinetunedModel? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ListFinetunedModelsResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.FinetunedModel>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Error? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CreateFinetunedModelResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GetFinetunedModelResponse? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DeleteFinetunedModelResponse? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UpdateFinetunedModelResponse? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Event? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ListEventsResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Event>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.TrainingStepMetrics? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ListTrainingStepMetricsResponse? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.TrainingStepMetrics>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatRequest? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatRequestPromptTruncation? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ChatConnector>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatRequestCitationQuality? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Tool>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatRequestSafetyMode? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Chatv2Request? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ToolV2>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.Document>>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::Cohere.Document>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Chatv2RequestSafetyMode? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.Chatv2RequestToolChoice? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseRequest? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateRequest? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateRequestTruncate? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GenerateRequestReturnLikelihoods? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedRequestTruncate? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.V2EmbedRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.EmbedInput>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.V2EmbedRequestTruncate? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AudioTranscriptionsCreateRequest? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankRequest? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.RerankDocument>>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::Cohere.RerankDocument>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.V2RerankRequest? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ClassifyRequest? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ClassifyExample>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ClassifyRequestTruncate? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DatasetDytngn? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SummarizeRequest? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SummarizeRequestLength? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SummarizeRequestFormat? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SummarizeRequestExtractiveness? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.TokenizeRequest? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DetokenizeRequest? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.FinetuningUpdateFinetunedModelRequest? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatAccepts? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.NotFoundErrorBody? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UnauthorizedErrorBody? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.BadRequestErrorBody? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.UnprocessableEntityErrorBody? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.GatewayTimeoutErrorBody? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ForbiddenErrorBody? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.InternalServerErrorBody? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ServiceUnavailableErrorBody? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.NotImplementedErrorBody? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.TooManyRequestsErrorBody? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.InvalidTokenErrorBody? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<global::Cohere.ChatResponseV2, global::Cohere.StreamedChatResponseV2?>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedResponse? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedResponseDiscriminator? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.EmbedResponseDiscriminatorResponseType? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.AudioTranscriptionsCreateResponse? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankResponse? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.RerankResponseResultsItem>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankResponseResultsItem? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.RerankResponseResultsItemDocument? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.V2RerankResponse? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.V2RerankResponseResultsItem>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.V2RerankResponseResultsItem? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.RerankRelevantSpanResponse>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ClassifyResponse? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.ClassifyResponseClassification>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ClassifyResponseClassification? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Cohere.ClassifyResponseClassificationLabels2>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ClassifyResponseClassificationLabels2? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ClassifyResponseClassificationClassificationType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DatasetsCreateResponse? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DatasetsListResponse? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cohere.Dataset>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DatasetsGetUsageResponse? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DatasetsGetResponse? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.SummarizeResponse? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.TokenizeResponse? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DetokenizeResponse? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.CheckApiKeyResponse? Type453 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ToolCall>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ToolResult>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ChatCitation>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ChatDocument>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ChatSearchQuery>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ChatSearchResult>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Message>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::System.Collections.Generic.List<global::Cohere.Content>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Content>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Source>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ToolCallV2>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::System.Collections.Generic.List<global::Cohere.ContentVariant2Item2>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ContentVariant2Item2>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Citation>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::System.Collections.Generic.List<global::Cohere.ContentVariant2Item>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ContentVariant2Item>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.OneOf<string, global::System.Collections.Generic.List<global::Cohere.ToolContent>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ToolContent>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ChatMessageV2>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ContentItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.LogprobItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ParseBlock>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ParseImageBlock>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ParsePage>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.SingleGenerationTokenLikelihoodsItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.SingleGeneration>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.SingleGenerationInStream>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Image>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.EmbedContent>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Batch>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.EmbedJob>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.EmbeddingType>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.LabelMetric>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.DatasetPart>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Connector>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ConnectorLog>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.TokenLikelihood>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Cluster>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.GetClusterJobResponse>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.CompatibleEndpoint>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.GetModelResponse>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.FinetunedModel>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Event>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.TrainingStepMetrics>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ChatConnector>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Tool>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ToolV2>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.OneOf<string, global::Cohere.Document>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.EmbedInput>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.OneOf<string, global::Cohere.RerankDocument>>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ClassifyExample>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.RerankResponseResultsItem>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.V2RerankResponseResultsItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.RerankRelevantSpanResponse>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.ClassifyResponseClassification>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.Dataset>? ListType62 { get; set; }
    }
}