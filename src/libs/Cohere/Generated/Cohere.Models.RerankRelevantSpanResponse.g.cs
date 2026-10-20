
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A stretch of a document that the model found relevant to the query, returned when context compression is enabled through `relevant_spans`.
    /// </summary>
    public sealed partial class RerankRelevantSpanResponse
    {
        /// <summary>
        /// The position of the span's first character in the document, counted in Unicode codepoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The position just past the span's last character, counted in Unicode codepoints, so the span covers `[start, end)` of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// How relevant the span is to the query, in the range `[0, 1]`. Only spans reaching the requested `threshold` are returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRelevantSpanResponse" /> class.
        /// </summary>
        /// <param name="start">
        /// The position of the span's first character in the document, counted in Unicode codepoints.
        /// </param>
        /// <param name="end">
        /// The position just past the span's last character, counted in Unicode codepoints, so the span covers `[start, end)` of the document.
        /// </param>
        /// <param name="score">
        /// How relevant the span is to the query, in the range `[0, 1]`. Only spans reaching the requested `threshold` are returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankRelevantSpanResponse(
            int start,
            int end,
            float score)
        {
            this.Start = start;
            this.End = end;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRelevantSpanResponse" /> class.
        /// </summary>
        public RerankRelevantSpanResponse()
        {
        }

    }
}