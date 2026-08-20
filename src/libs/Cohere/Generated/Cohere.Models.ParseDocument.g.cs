
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
        /// Image URL or base64 data URI to parse.<br/>
        /// Limits:<br/>
        /// - Maximum file size: 20 MB (compressed upload, download, or decoded<br/>
        ///   data-URI payload)<br/>
        /// - Maximum decoded size: 50 megapixels or 200 MB decompressed<br/>
        ///   (whichever is exceeded first)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseDocument" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Image URL or base64 data URI to parse.<br/>
        /// Limits:<br/>
        /// - Maximum file size: 20 MB (compressed upload, download, or decoded<br/>
        ///   data-URI payload)<br/>
        /// - Maximum decoded size: 50 megapixels or 200 MB decompressed<br/>
        ///   (whichever is exceeded first)
        /// </param>
        /// <param name="type">
        /// Discriminator for the document payload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseDocument(
            string imageUrl,
            global::Cohere.ParseDocumentType type)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseDocument" /> class.
        /// </summary>
        public ParseDocument()
        {
        }

    }
}