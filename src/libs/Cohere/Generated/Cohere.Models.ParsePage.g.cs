
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A single parsed page.
    /// </summary>
    public sealed partial class ParsePage
    {
        /// <summary>
        /// Zero-based page index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Page content as markdown. Image and table assets are referenced with<br/>
        /// placeholders such as `![img-0](img-0)` and `[tbl-0](tbl-0)`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Ordered content blocks with optional bounding boxes. Only present when<br/>
        /// `include_blocks` was `true` in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        public global::System.Collections.Generic.IList<global::Cohere.ParseBlock>? Blocks { get; set; }

        /// <summary>
        /// Images extracted from the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Cohere.ParseImage>? Images { get; set; }

        /// <summary>
        /// Tables extracted from the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::Cohere.ParseTable>? Tables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsePage" /> class.
        /// </summary>
        /// <param name="index">
        /// Zero-based page index.
        /// </param>
        /// <param name="markdown">
        /// Page content as markdown. Image and table assets are referenced with<br/>
        /// placeholders such as `![img-0](img-0)` and `[tbl-0](tbl-0)`.
        /// </param>
        /// <param name="blocks">
        /// Ordered content blocks with optional bounding boxes. Only present when<br/>
        /// `include_blocks` was `true` in the request.
        /// </param>
        /// <param name="images">
        /// Images extracted from the page.
        /// </param>
        /// <param name="tables">
        /// Tables extracted from the page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParsePage(
            int index,
            string markdown,
            global::System.Collections.Generic.IList<global::Cohere.ParseBlock>? blocks,
            global::System.Collections.Generic.IList<global::Cohere.ParseImage>? images,
            global::System.Collections.Generic.IList<global::Cohere.ParseTable>? tables)
        {
            this.Index = index;
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
            this.Blocks = blocks;
            this.Images = images;
            this.Tables = tables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsePage" /> class.
        /// </summary>
        public ParsePage()
        {
        }

    }
}