
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ChatStreamEventEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ChatStreamEventEventType EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}