
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A parsed page with structured content blocks.
    /// </summary>
    public sealed partial class ParseBlocksPageVariant
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseBlocksPageVariantTypeJsonConverter))]
        public global::Cohere.ParseBlocksPageVariantType Type { get; set; }

        /// <summary>
        /// Ordered content blocks extracted from the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cohere.ParseBlock> Blocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBlocksPageVariant" /> class.
        /// </summary>
        /// <param name="index">
        /// Zero-based page index.
        /// </param>
        /// <param name="blocks">
        /// Ordered content blocks extracted from the page.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseBlocksPageVariant(
            int index,
            global::System.Collections.Generic.IList<global::Cohere.ParseBlock> blocks,
            global::Cohere.ParseBlocksPageVariantType type)
        {
            this.Index = index;
            this.Type = type;
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBlocksPageVariant" /> class.
        /// </summary>
        public ParseBlocksPageVariant()
        {
        }

    }
}