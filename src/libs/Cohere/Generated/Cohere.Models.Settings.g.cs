
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// The configuration used for fine-tuning.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class Settings
    {
        /// <summary>
        /// The base model to fine-tune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::Cohere.BaseModel BaseModel { get; set; }

        /// <summary>
        /// The data used for training and evaluating the fine-tuned model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Fine-tuning hyper-parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Cohere.Hyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// read-only. Whether the model is single-label or multi-label (only for classification).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_label")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? MultiLabel { get; set; }

        /// <summary>
        /// The Weights &amp; Biases configuration (Chat fine-tuning only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Cohere.WandbConfig? Wandb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// The base model to fine-tune.
        /// </param>
        /// <param name="datasetId">
        /// The data used for training and evaluating the fine-tuned model.
        /// </param>
        /// <param name="multiLabel">
        /// read-only. Whether the model is single-label or multi-label (only for classification).<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Settings(
            global::Cohere.BaseModel baseModel,
            string datasetId,
            bool? multiLabel)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.MultiLabel = multiLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
        }

    }
}