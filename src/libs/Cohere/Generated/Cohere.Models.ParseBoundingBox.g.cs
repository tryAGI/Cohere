
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A bounding box with pixel coordinates on the source document image.
    /// </summary>
    public sealed partial class ParseBoundingBox
    {
        /// <summary>
        /// X coordinate of the top-left corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopLeftX { get; set; }

        /// <summary>
        /// Y coordinate of the top-left corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopLeftY { get; set; }

        /// <summary>
        /// X coordinate of the bottom-right corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BottomRightX { get; set; }

        /// <summary>
        /// Y coordinate of the bottom-right corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BottomRightY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBoundingBox" /> class.
        /// </summary>
        /// <param name="topLeftX">
        /// X coordinate of the top-left corner.
        /// </param>
        /// <param name="topLeftY">
        /// Y coordinate of the top-left corner.
        /// </param>
        /// <param name="bottomRightX">
        /// X coordinate of the bottom-right corner.
        /// </param>
        /// <param name="bottomRightY">
        /// Y coordinate of the bottom-right corner.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseBoundingBox(
            int topLeftX,
            int topLeftY,
            int bottomRightX,
            int bottomRightY)
        {
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBoundingBox" /> class.
        /// </summary>
        public ParseBoundingBox()
        {
        }

    }
}