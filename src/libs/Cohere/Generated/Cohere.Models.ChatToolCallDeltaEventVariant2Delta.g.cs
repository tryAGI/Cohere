
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventVariant2Delta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call")]
        public global::Cohere.ChatToolCallDeltaEventVariant2DeltaToolCall? ToolCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2Delta" /> class.
        /// </summary>
        /// <param name="toolCall"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatToolCallDeltaEventVariant2Delta(
            global::Cohere.ChatToolCallDeltaEventVariant2DeltaToolCall? toolCall)
        {
            this.ToolCall = toolCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2Delta" /> class.
        /// </summary>
        public ChatToolCallDeltaEventVariant2Delta()
        {
        }
    }
}