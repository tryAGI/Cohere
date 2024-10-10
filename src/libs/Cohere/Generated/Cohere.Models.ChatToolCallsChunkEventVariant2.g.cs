
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallsChunkEventVariant2
    {
        /// <summary>
        /// Contains the chunk of the tool call generation in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ToolCallDelta ToolCallDelta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}