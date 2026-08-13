
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Extracted image asset from a parsed page.
    /// </summary>
    public sealed partial class ParseImage
    {
        /// <summary>
        /// Unique identifier for the image within the page (for example `img-0`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Model-generated description / annotation of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_annotation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageAnnotation { get; set; }

        /// <summary>
        /// X coordinate of the top-left corner of the image bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_x")]
        public int? TopLeftX { get; set; }

        /// <summary>
        /// Y coordinate of the top-left corner of the image bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_y")]
        public int? TopLeftY { get; set; }

        /// <summary>
        /// X coordinate of the bottom-right corner of the image bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_x")]
        public int? BottomRightX { get; set; }

        /// <summary>
        /// Y coordinate of the bottom-right corner of the image bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_y")]
        public int? BottomRightY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseImage" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the image within the page (for example `img-0`).
        /// </param>
        /// <param name="imageAnnotation">
        /// Model-generated description / annotation of the image.
        /// </param>
        /// <param name="topLeftX">
        /// X coordinate of the top-left corner of the image bounding box.
        /// </param>
        /// <param name="topLeftY">
        /// Y coordinate of the top-left corner of the image bounding box.
        /// </param>
        /// <param name="bottomRightX">
        /// X coordinate of the bottom-right corner of the image bounding box.
        /// </param>
        /// <param name="bottomRightY">
        /// Y coordinate of the bottom-right corner of the image bounding box.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseImage(
            string id,
            string imageAnnotation,
            int? topLeftX,
            int? topLeftY,
            int? bottomRightX,
            int? bottomRightY)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ImageAnnotation = imageAnnotation ?? throw new global::System.ArgumentNullException(nameof(imageAnnotation));
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseImage" /> class.
        /// </summary>
        public ParseImage()
        {
        }

    }
}