
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Extracted table asset from a parsed page.
    /// </summary>
    public sealed partial class ParseTable
    {
        /// <summary>
        /// Unique identifier for the table within the page (for example `tbl-0.html`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Serialization format of `content`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseTableFormatJsonConverter))]
        public global::Cohere.ParseTableFormat Format { get; set; }

        /// <summary>
        /// Table content in the format specified by `format`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Optional table title when detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// X coordinate of the top-left corner of the table bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_x")]
        public int? TopLeftX { get; set; }

        /// <summary>
        /// Y coordinate of the top-left corner of the table bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_y")]
        public int? TopLeftY { get; set; }

        /// <summary>
        /// X coordinate of the bottom-right corner of the table bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_x")]
        public int? BottomRightX { get; set; }

        /// <summary>
        /// Y coordinate of the bottom-right corner of the table bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_y")]
        public int? BottomRightY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseTable" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the table within the page (for example `tbl-0.html`).
        /// </param>
        /// <param name="content">
        /// Table content in the format specified by `format`.
        /// </param>
        /// <param name="format">
        /// Serialization format of `content`.
        /// </param>
        /// <param name="title">
        /// Optional table title when detected.
        /// </param>
        /// <param name="topLeftX">
        /// X coordinate of the top-left corner of the table bounding box.
        /// </param>
        /// <param name="topLeftY">
        /// Y coordinate of the top-left corner of the table bounding box.
        /// </param>
        /// <param name="bottomRightX">
        /// X coordinate of the bottom-right corner of the table bounding box.
        /// </param>
        /// <param name="bottomRightY">
        /// Y coordinate of the bottom-right corner of the table bounding box.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseTable(
            string id,
            string content,
            global::Cohere.ParseTableFormat format,
            string? title,
            int? topLeftX,
            int? topLeftY,
            int? bottomRightX,
            int? bottomRightY)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Format = format;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Title = title;
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseTable" /> class.
        /// </summary>
        public ParseTable()
        {
        }

    }
}