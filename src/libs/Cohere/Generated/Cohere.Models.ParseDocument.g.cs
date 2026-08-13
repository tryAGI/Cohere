
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Document to parse. Currently only `image_url` documents are supported.
    /// </summary>
    public sealed partial class ParseDocument
    {
        /// <summary>
        /// Discriminator for the document payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseDocumentTypeJsonConverter))]
        public global::Cohere.ParseDocumentType Type { get; set; }

        /// <summary>
        /// Image to parse. Accepts either a bare URL / data URI string, or an object with<br/>
        /// `url` and optional `detail`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::Cohere.ImageUrl>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.OneOf<string, global::Cohere.ImageUrl> ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseDocument" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Image to parse. Accepts either a bare URL / data URI string, or an object with<br/>
        /// `url` and optional `detail`.
        /// </param>
        /// <param name="type">
        /// Discriminator for the document payload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseDocument(
            global::Cohere.OneOf<string, global::Cohere.ImageUrl> imageUrl,
            global::Cohere.ParseDocumentType type)
        {
            this.Type = type;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseDocument" /> class.
        /// </summary>
        public ParseDocument()
        {
        }

    }
}