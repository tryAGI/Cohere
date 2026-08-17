
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A content block on a parsed page. Present when `include_blocks` is `true`.
    /// </summary>
    public sealed partial class ParseBlock
    {
        /// <summary>
        /// Block kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseBlockTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseBlockType Type { get; set; }

        /// <summary>
        /// Content for this block. For text blocks this is the extracted text (same<br/>
        /// span as in `page.markdown`); for image blocks this is<br/>
        /// `![&lt;image_annotation&gt;](&lt;image_id&gt;)`; for table blocks this is the table<br/>
        /// HTML. When `table_format=html`, `page.markdown` uses a placeholder such as<br/>
        /// `[tbl-0.html](tbl-0.html)` while this field and `page.tables[].content`<br/>
        /// still carry the HTML.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// X coordinate of the top-left corner of the block bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_x")]
        public int? TopLeftX { get; set; }

        /// <summary>
        /// Y coordinate of the top-left corner of the block bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_y")]
        public int? TopLeftY { get; set; }

        /// <summary>
        /// X coordinate of the bottom-right corner of the block bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_x")]
        public int? BottomRightX { get; set; }

        /// <summary>
        /// Y coordinate of the bottom-right corner of the block bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_y")]
        public int? BottomRightY { get; set; }

        /// <summary>
        /// ID of the corresponding entry in `page.images` when `type` is `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// ID of the corresponding entry in `page.tables` when `type` is `table` and<br/>
        /// `table_format` extracted tables (for example `html`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Block kind.
        /// </param>
        /// <param name="content">
        /// Content for this block. For text blocks this is the extracted text (same<br/>
        /// span as in `page.markdown`); for image blocks this is<br/>
        /// `![&lt;image_annotation&gt;](&lt;image_id&gt;)`; for table blocks this is the table<br/>
        /// HTML. When `table_format=html`, `page.markdown` uses a placeholder such as<br/>
        /// `[tbl-0.html](tbl-0.html)` while this field and `page.tables[].content`<br/>
        /// still carry the HTML.
        /// </param>
        /// <param name="topLeftX">
        /// X coordinate of the top-left corner of the block bounding box.
        /// </param>
        /// <param name="topLeftY">
        /// Y coordinate of the top-left corner of the block bounding box.
        /// </param>
        /// <param name="bottomRightX">
        /// X coordinate of the bottom-right corner of the block bounding box.
        /// </param>
        /// <param name="bottomRightY">
        /// Y coordinate of the bottom-right corner of the block bounding box.
        /// </param>
        /// <param name="imageId">
        /// ID of the corresponding entry in `page.images` when `type` is `image`.
        /// </param>
        /// <param name="tableId">
        /// ID of the corresponding entry in `page.tables` when `type` is `table` and<br/>
        /// `table_format` extracted tables (for example `html`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseBlock(
            global::Cohere.ParseBlockType type,
            string content,
            int? topLeftX,
            int? topLeftY,
            int? bottomRightX,
            int? bottomRightY,
            string? imageId,
            string? tableId)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
            this.ImageId = imageId;
            this.TableId = tableId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBlock" /> class.
        /// </summary>
        public ParseBlock()
        {
        }

    }
}