
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedByTypeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.EmbedByTypeResponseResponseTypeJsonConverter))]
        public global::Cohere.EmbedByTypeResponseResponseType? ResponseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An object with different embedding types. The length of each embedding type array will be the same as the length of the original `texts` array.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::Cohere.EmbedByTypeResponseEmbeddings Embeddings { get; set; } = default!;

        /// <summary>
        /// The text entries for which embeddings were returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Texts { get; set; }

        /// <summary>
        /// The image entries for which embeddings were returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Cohere.Image>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Cohere.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedByTypeResponse" /> class.
        /// </summary>
        /// <param name="responseType"></param>
        /// <param name="id"></param>
        /// <param name="embeddings">
        /// An object with different embedding types. The length of each embedding type array will be the same as the length of the original `texts` array.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="texts">
        /// The text entries for which embeddings were returned.
        /// </param>
        /// <param name="images">
        /// The image entries for which embeddings were returned.
        /// </param>
        /// <param name="meta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EmbedByTypeResponse(
            string id,
            global::System.Collections.Generic.IList<string> texts,
            global::Cohere.EmbedByTypeResponseResponseType? responseType,
            global::System.Collections.Generic.IList<global::Cohere.Image>? images,
            global::Cohere.ApiMeta? meta,
            global::Cohere.EmbedByTypeResponseEmbeddings embeddings = default!)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Texts = texts ?? throw new global::System.ArgumentNullException(nameof(texts));
            this.ResponseType = responseType;
            this.Embeddings = embeddings;
            this.Images = images;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedByTypeResponse" /> class.
        /// </summary>
        public EmbedByTypeResponse()
        {
        }
    }
}