
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The fine-tuning hyperparameters.
    /// </summary>
    public sealed partial class Hyperparameters
    {
        /// <summary>
        /// Stops training if the loss metric does not improve beyond the value of<br/>
        /// `early_stopping_threshold` after this many times of evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("early_stopping_patience")]
        public int EarlyStoppingPatience { get; set; }

        /// <summary>
        /// How much the loss must improve to prevent early stopping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("early_stopping_threshold")]
        public double EarlyStoppingThreshold { get; set; }

        /// <summary>
        /// The batch size is the number of training examples included in a single<br/>
        /// training pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_batch_size")]
        public int TrainBatchSize { get; set; }

        /// <summary>
        /// The number of epochs to train for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_epochs")]
        public int TrainEpochs { get; set; }

        /// <summary>
        /// The learning rate to be used during training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double LearningRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}