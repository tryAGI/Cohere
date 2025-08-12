
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentDeltaEventVariant2DeltaMessageContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public string? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2DeltaMessageContent" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="thinking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentDeltaEventVariant2DeltaMessageContent(
            string? text,
            string? thinking)
        {
            this.Text = text;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2DeltaMessageContent" /> class.
        /// </summary>
        public ChatContentDeltaEventVariant2DeltaMessageContent()
        {
        }
    }
}