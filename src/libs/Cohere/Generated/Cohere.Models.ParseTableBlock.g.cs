
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Payload for a table block.
    /// </summary>
    public sealed partial class ParseTableBlock
    {
        /// <summary>
        /// Table serialization format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseTableContentTypeJsonConverter))]
        public global::Cohere.ParseTableContentType Type { get; set; }

        /// <summary>
        /// Table content as HTML.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// Optional table title when detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Optional table description when detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A bounding box with pixel coordinates on the source document image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseBoundingBox BoundingBox { get; set; }

        /// <summary>
        /// A bounding box with coordinates in [0, 1] relative to the source page (model<br/>
        /// coordinates are thousandths of page width/height).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box_normalized")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseBoundingBoxNormalized BoundingBoxNormalized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseTableBlock" /> class.
        /// </summary>
        /// <param name="html">
        /// Table content as HTML.
        /// </param>
        /// <param name="boundingBox">
        /// A bounding box with pixel coordinates on the source document image.
        /// </param>
        /// <param name="boundingBoxNormalized">
        /// A bounding box with coordinates in [0, 1] relative to the source page (model<br/>
        /// coordinates are thousandths of page width/height).
        /// </param>
        /// <param name="type">
        /// Table serialization format.
        /// </param>
        /// <param name="title">
        /// Optional table title when detected.
        /// </param>
        /// <param name="description">
        /// Optional table description when detected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseTableBlock(
            string html,
            global::Cohere.ParseBoundingBox boundingBox,
            global::Cohere.ParseBoundingBoxNormalized boundingBoxNormalized,
            global::Cohere.ParseTableContentType type,
            string? title,
            string? description)
        {
            this.Type = type;
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Title = title;
            this.Description = description;
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
            this.BoundingBoxNormalized = boundingBoxNormalized ?? throw new global::System.ArgumentNullException(nameof(boundingBoxNormalized));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseTableBlock" /> class.
        /// </summary>
        public ParseTableBlock()
        {
        }

    }
}