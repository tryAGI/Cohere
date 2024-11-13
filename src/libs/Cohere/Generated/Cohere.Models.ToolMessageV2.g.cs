
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A message with Tool outputs.
    /// </summary>
    public sealed partial class ToolMessageV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ToolMessageV2RoleJsonConverter))]
        public global::Cohere.ToolMessageV2Role Role { get; set; }

        /// <summary>
        /// The id of the associated tool call that has provided the given content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Outputs from a tool. The content should formatted as a JSON object string, or a list of tool content blocks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageV2" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="toolCallId">
        /// The id of the associated tool call that has provided the given content
        /// </param>
        /// <param name="content">
        /// Outputs from a tool. The content should formatted as a JSON object string, or a list of tool content blocks
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolMessageV2(
            string toolCallId,
            global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ToolContent>> content,
            global::Cohere.ToolMessageV2Role role)
        {
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageV2" /> class.
        /// </summary>
        public ToolMessageV2()
        {
        }
    }
}