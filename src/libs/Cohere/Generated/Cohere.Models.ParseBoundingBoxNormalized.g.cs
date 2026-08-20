
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A bounding box with coordinates in [0, 1] relative to the source page (model<br/>
    /// coordinates are thousandths of page width/height).
    /// </summary>
    public sealed partial class ParseBoundingBoxNormalized
    {
        /// <summary>
        /// Normalized X coordinate of the top-left corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TopLeftX { get; set; }

        /// <summary>
        /// Normalized Y coordinate of the top-left corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TopLeftY { get; set; }

        /// <summary>
        /// Normalized X coordinate of the bottom-right corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BottomRightX { get; set; }

        /// <summary>
        /// Normalized Y coordinate of the bottom-right corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BottomRightY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBoundingBoxNormalized" /> class.
        /// </summary>
        /// <param name="topLeftX">
        /// Normalized X coordinate of the top-left corner.
        /// </param>
        /// <param name="topLeftY">
        /// Normalized Y coordinate of the top-left corner.
        /// </param>
        /// <param name="bottomRightX">
        /// Normalized X coordinate of the bottom-right corner.
        /// </param>
        /// <param name="bottomRightY">
        /// Normalized Y coordinate of the bottom-right corner.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseBoundingBoxNormalized(
            double topLeftX,
            double topLeftY,
            double bottomRightX,
            double bottomRightY)
        {
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBoundingBoxNormalized" /> class.
        /// </summary>
        public ParseBoundingBoxNormalized()
        {
        }

    }
}