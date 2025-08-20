
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Thinking content of the message. This will be present when `thinking` is enabled, and will contain the models internal reasoning.
    /// </summary>
    public sealed partial class ChatThinkingContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ChatThinkingContentTypeJsonConverter))]
        public global::Cohere.ChatThinkingContentType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatThinkingContent" /> class.
        /// </summary>
        /// <param name="thinking"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatThinkingContent(
            string thinking,
            global::Cohere.ChatThinkingContentType type)
        {
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatThinkingContent" /> class.
        /// </summary>
        public ChatThinkingContent()
        {
        }
    }
}