
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response to a request to list training-step metrics of a fine-tuned model.
    /// </summary>
    public sealed partial class ListTrainingStepMetricsResponse
    {
        /// <summary>
        /// The metrics for each step the evaluation was run on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_metrics")]
        public global::System.Collections.Generic.IList<global::Cohere.TrainingStepMetrics>? StepMetrics { get; set; }

        /// <summary>
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingStepMetricsResponse" /> class.
        /// </summary>
        /// <param name="stepMetrics">
        /// The metrics for each step the evaluation was run on.
        /// </param>
        /// <param name="nextPageToken">
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTrainingStepMetricsResponse(
            global::System.Collections.Generic.IList<global::Cohere.TrainingStepMetrics>? stepMetrics,
            string? nextPageToken)
        {
            this.StepMetrics = stepMetrics;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingStepMetricsResponse" /> class.
        /// </summary>
        public ListTrainingStepMetricsResponse()
        {
        }
    }
}