
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamEndEventVariant2
    {
        /// <summary>
        /// - `COMPLETE` - the model sent back a finished reply<br/>
        /// - `ERROR_LIMIT` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
        /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens specified by the max_tokens parameter<br/>
        /// - `ERROR` - something went wrong when generating the reply<br/>
        /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ChatStreamEndEventVariant2FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ChatStreamEndEventVariant2FinishReason FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.NonStreamedChatResponse Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}