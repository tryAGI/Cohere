
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The streamed event types
    /// </summary>
    public sealed partial class ChatStreamEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ChatStreamEventTypeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ChatStreamEventTypeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEventType" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamEventType(
            global::Cohere.ChatStreamEventTypeType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEventType" /> class.
        /// </summary>
        public ChatStreamEventType()
        {
        }
    }
}