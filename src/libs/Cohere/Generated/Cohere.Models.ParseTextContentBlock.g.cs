
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A text content block.
    /// </summary>
    public sealed partial class ParseTextContentBlock
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseTextContentBlockTypeJsonConverter))]
        public global::Cohere.ParseTextContentBlockType Type { get; set; }

        /// <summary>
        /// Payload for a text block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseTextBlock Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseTextContentBlock" /> class.
        /// </summary>
        /// <param name="text">
        /// Payload for a text block.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseTextContentBlock(
            global::Cohere.ParseTextBlock text,
            global::Cohere.ParseTextContentBlockType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseTextContentBlock" /> class.
        /// </summary>
        public ParseTextContentBlock()
        {
        }

    }
}