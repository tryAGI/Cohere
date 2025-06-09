
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolSource
    {
        /// <summary>
        /// The unique identifier of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_output")]
        public object? ToolOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolSource" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the document
        /// </param>
        /// <param name="toolOutput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatToolSource(
            string? id,
            object? toolOutput)
        {
            this.Id = id;
            this.ToolOutput = toolOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolSource" /> class.
        /// </summary>
        public ChatToolSource()
        {
        }
    }
}