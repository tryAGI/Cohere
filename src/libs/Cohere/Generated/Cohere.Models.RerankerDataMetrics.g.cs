
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankerDataMetrics
    {
        /// <summary>
        /// The number of training queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_train_queries")]
        public double? NumTrainQueries { get; set; }

        /// <summary>
        /// The sum of all relevant passages of valid training examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_train_relevant_passages")]
        public double? NumTrainRelevantPassages { get; set; }

        /// <summary>
        /// The sum of all hard negatives of valid training examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_train_hard_negatives")]
        public double? NumTrainHardNegatives { get; set; }

        /// <summary>
        /// The number of evaluation queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_eval_queries")]
        public double? NumEvalQueries { get; set; }

        /// <summary>
        /// The sum of all relevant passages of valid eval examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_eval_relevant_passages")]
        public double? NumEvalRelevantPassages { get; set; }

        /// <summary>
        /// The sum of all hard negatives of valid eval examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_eval_hard_negatives")]
        public double? NumEvalHardNegatives { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}