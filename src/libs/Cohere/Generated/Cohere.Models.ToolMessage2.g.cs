
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A message from the system.
    /// </summary>
    public sealed partial class ToolMessage2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ToolMessage2RoleJsonConverter))]
        public global::Cohere.ToolMessage2Role Role { get; set; }

        /// <summary>
        /// The id of the associated tool call that has provided the given content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// A list of outputs from a tool. The content should formatted as a JSON object string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ToolContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}