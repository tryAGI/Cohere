
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallStartEventVariant2DeltaToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ChatToolCallStartEventVariant2DeltaToolCallTypeJsonConverter))]
        public global::Cohere.ChatToolCallStartEventVariant2DeltaToolCallType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::Cohere.ChatToolCallStartEventVariant2DeltaToolCallFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}