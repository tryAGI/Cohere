
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Cohere.RerankerDataMetrics? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Cohere.RerankerDataMetrics),
                jsonSerializerContext) as global::Cohere.RerankerDataMetrics;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Cohere.RerankerDataMetrics? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Cohere.RerankerDataMetrics>(
                json,
                jsonSerializerOptions);
        }

    }
}