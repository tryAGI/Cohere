
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
        /// Page content as markdown. Images are embedded as<br/>
        /// `![&lt;image_annotation&gt;](&lt;image_id&gt;)`. By default, tables are inlined as HTML.<br/>
        /// When `table_format=html`, tables are replaced with placeholders such as<br/>
        /// `[tbl-0.html](tbl-0.html)` that map to `tables`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Ordered content blocks with optional bounding boxes. Only present when<br/>
        /// `include_blocks` was `true` in the request. Text and image block `content`<br/>
        /// match the corresponding span in `markdown`. Table block `content` is the<br/>
        /// table HTML (see `ParseBlock`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        public global::System.Collections.Generic.IList<global::Cohere.ParseBlock>? Blocks { get; set; }

        /// <summary>
        /// Images extracted from the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Cohere.ParseImage>? Images { get; set; }

        /// <summary>
        /// Tables extracted from the page. Only present when `table_format` is set<br/>
        /// (for example `html`).
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
        /// Page content as markdown. Images are embedded as<br/>
        /// `![&lt;image_annotation&gt;](&lt;image_id&gt;)`. By default, tables are inlined as HTML.<br/>
        /// When `table_format=html`, tables are replaced with placeholders such as<br/>
        /// `[tbl-0.html](tbl-0.html)` that map to `tables`.
        /// </param>
        /// <param name="blocks">
        /// Ordered content blocks with optional bounding boxes. Only present when<br/>
        /// `include_blocks` was `true` in the request. Text and image block `content`<br/>
        /// match the corresponding span in `markdown`. Table block `content` is the<br/>
        /// table HTML (see `ParseBlock`).
        /// </param>
        /// <param name="images">
        /// Images extracted from the page.
        /// </param>
        /// <param name="tables">
        /// Tables extracted from the page. Only present when `table_format` is set<br/>
        /// (for example `html`).
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