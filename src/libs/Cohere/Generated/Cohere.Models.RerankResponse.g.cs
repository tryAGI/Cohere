
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An ordered list of ranked documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cohere.RerankResponseResult> Results { get; set; }

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
        /// Initializes a new instance of the <see cref="RerankResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="results">
        /// An ordered list of ranked documents
        /// </param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResponse(
            global::System.Collections.Generic.IList<global::Cohere.RerankResponseResult> results,
            string? id,
            global::Cohere.ApiMeta? meta)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Id = id;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse" /> class.
        /// </summary>
        public RerankResponse()
        {
        }
    }
}