
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Payload for an image block.
    /// </summary>
    public sealed partial class ParseImageBlock
    {
        /// <summary>
        /// Unique identifier for the image within the page (for example `img-0`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Model-generated description of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Image element category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseImageCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseImageCategory Category { get; set; }

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
        /// Initializes a new instance of the <see cref="ParseImageBlock" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the image within the page (for example `img-0`).
        /// </param>
        /// <param name="description">
        /// Model-generated description of the image.
        /// </param>
        /// <param name="category">
        /// Image element category.
        /// </param>
        /// <param name="boundingBox">
        /// A bounding box with pixel coordinates on the source document image.
        /// </param>
        /// <param name="boundingBoxNormalized">
        /// A bounding box with coordinates in [0, 1] relative to the source page (model<br/>
        /// coordinates are thousandths of page width/height).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseImageBlock(
            string id,
            string description,
            global::Cohere.ParseImageCategory category,
            global::Cohere.ParseBoundingBox boundingBox,
            global::Cohere.ParseBoundingBoxNormalized boundingBoxNormalized)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Category = category;
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
            this.BoundingBoxNormalized = boundingBoxNormalized ?? throw new global::System.ArgumentNullException(nameof(boundingBoxNormalized));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseImageBlock" /> class.
        /// </summary>
        public ParseImageBlock()
        {
        }

    }
}