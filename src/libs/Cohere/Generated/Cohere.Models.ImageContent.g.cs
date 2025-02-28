
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Image content of the message.
    /// </summary>
    public sealed partial class ImageContent
    {
        /// <summary>
        /// Type of message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ContentType Type { get; set; }

        /// <summary>
        /// Base64 url of image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of message content
        /// </param>
        /// <param name="imageUrl">
        /// Base64 url of image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageContent(
            global::Cohere.ContentType type,
            global::Cohere.ImageUrl imageUrl)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        public ImageContent()
        {
        }
    }
}