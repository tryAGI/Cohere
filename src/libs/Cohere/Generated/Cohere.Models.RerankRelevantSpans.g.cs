
#nullable enable

namespace Cohere
{
    /// <summary>
    /// When enabled, the API response will include the relevant spans of each document that contributed to its rank. This feature is only supported for Rerank v5 and newer models.
    /// </summary>
    public sealed partial class RerankRelevantSpans
    {
        /// <summary>
        /// One of `"enabled"` or `"disabled"`. Controls whether relevant spans will be returned in the API response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.RerankRelevantSpansModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.RerankRelevantSpansMode Mode { get; set; }

        /// <summary>
        /// Only spans with a relevance score higher than the specified threshold value will be included in the response. Defaults to `0.1`.<br/>
        /// Default Value: 0.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public float? Threshold { get; set; }

        /// <summary>
        /// The maximum number of relevant spans to include per document. If not set, all relevant spans will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_spans")]
        public int? MaxSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRelevantSpans" /> class.
        /// </summary>
        /// <param name="mode">
        /// One of `"enabled"` or `"disabled"`. Controls whether relevant spans will be returned in the API response.
        /// </param>
        /// <param name="threshold">
        /// Only spans with a relevance score higher than the specified threshold value will be included in the response. Defaults to `0.1`.<br/>
        /// Default Value: 0.1
        /// </param>
        /// <param name="maxSpans">
        /// The maximum number of relevant spans to include per document. If not set, all relevant spans will be returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankRelevantSpans(
            global::Cohere.RerankRelevantSpansMode mode,
            float? threshold,
            int? maxSpans)
        {
            this.Mode = mode;
            this.Threshold = threshold;
            this.MaxSpans = maxSpans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRelevantSpans" /> class.
        /// </summary>
        public RerankRelevantSpans()
        {
        }

    }
}