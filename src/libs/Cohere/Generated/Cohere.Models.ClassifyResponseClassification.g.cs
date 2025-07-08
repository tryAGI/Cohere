
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifyResponseClassification
    {
        /// <summary>
        /// The type of classification performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ClassifyResponseClassificationClassificationType ClassificationType { get; set; }

        /// <summary>
        /// The confidence score for the top predicted class (only filled for single-label classification)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public float? Confidence { get; set; }

        /// <summary>
        /// An array containing the confidence scores of all the predictions in the same order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<float> Confidences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The input text that was classified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Cohere.ClassifyResponseClassificationLabels2> Labels { get; set; }

        /// <summary>
        /// The predicted label for the associated query (only filled for single-label models)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Prediction { get; set; }

        /// <summary>
        /// An array containing the predicted labels for the associated query (only filled for single-label classification)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponseClassification" /> class.
        /// </summary>
        /// <param name="classificationType">
        /// The type of classification performed
        /// </param>
        /// <param name="confidences">
        /// An array containing the confidence scores of all the predictions in the same order
        /// </param>
        /// <param name="id"></param>
        /// <param name="input">
        /// The input text that was classified
        /// </param>
        /// <param name="labels">
        /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.
        /// </param>
        /// <param name="predictions">
        /// An array containing the predicted labels for the associated query (only filled for single-label classification)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyResponseClassification(
            global::Cohere.ClassifyResponseClassificationClassificationType classificationType,
            global::System.Collections.Generic.IList<float> confidences,
            string id,
            global::System.Collections.Generic.Dictionary<string, global::Cohere.ClassifyResponseClassificationLabels2> labels,
            global::System.Collections.Generic.IList<string> predictions,
            string? input)
        {
            this.ClassificationType = classificationType;
            this.Confidences = confidences ?? throw new global::System.ArgumentNullException(nameof(confidences));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponseClassification" /> class.
        /// </summary>
        public ClassifyResponseClassification()
        {
        }
    }
}