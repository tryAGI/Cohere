
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentDeltaEventVariant2DeltaMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Cohere.ChatContentDeltaEventVariant2DeltaMessageContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2DeltaMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentDeltaEventVariant2DeltaMessage(
            global::Cohere.ChatContentDeltaEventVariant2DeltaMessageContent? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2DeltaMessage" /> class.
        /// </summary>
        public ChatContentDeltaEventVariant2DeltaMessage()
        {
        }
    }
}