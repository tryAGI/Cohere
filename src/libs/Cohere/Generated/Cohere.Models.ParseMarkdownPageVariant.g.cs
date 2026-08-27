
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A parsed page with markdown content.
    /// </summary>
    public sealed partial class ParseMarkdownPageVariant
    {
        /// <summary>
        /// Zero-based page index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseMarkdownPageVariantTypeJsonConverter))]
        public global::Cohere.ParseMarkdownPageVariantType Type { get; set; }

        /// <summary>
        /// Markdown output payload for a parsed page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseMarkdownPage Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseMarkdownPageVariant" /> class.
        /// </summary>
        /// <param name="index">
        /// Zero-based page index.
        /// </param>
        /// <param name="markdown">
        /// Markdown output payload for a parsed page.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseMarkdownPageVariant(
            int index,
            global::Cohere.ParseMarkdownPage markdown,
            global::Cohere.ParseMarkdownPageVariantType type)
        {
            this.Index = index;
            this.Type = type;
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseMarkdownPageVariant" /> class.
        /// </summary>
        public ParseMarkdownPageVariant()
        {
        }

    }
}