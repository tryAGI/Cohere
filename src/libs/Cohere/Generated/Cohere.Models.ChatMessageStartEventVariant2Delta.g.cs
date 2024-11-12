
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageStartEventVariant2Delta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Cohere.ChatMessageStartEventVariant2DeltaMessage? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventVariant2Delta" /> class.
        /// </summary>
        /// <param name="message"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatMessageStartEventVariant2Delta(
            global::Cohere.ChatMessageStartEventVariant2DeltaMessage? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventVariant2Delta" /> class.
        /// </summary>
        public ChatMessageStartEventVariant2Delta()
        {
        }
    }
}