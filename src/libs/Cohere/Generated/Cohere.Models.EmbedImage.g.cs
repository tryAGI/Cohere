
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::Cohere.EmbedImageProperties? Image { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.EmbedContentTypeJsonConverter))]
        public global::Cohere.EmbedContentType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedImage" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="type">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedImage(
            global::Cohere.EmbedImageProperties? image,
            global::Cohere.EmbedContentType? type)
        {
            this.Image = image;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedImage" /> class.
        /// </summary>
        public EmbedImage()
        {
        }
    }
}