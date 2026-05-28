
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Default sampling parameters for this model when omitted from API requests.
    /// </summary>
    public sealed partial class GetModelResponseSamplingDefaults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k")]
        public int? K { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p")]
        public float? P { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_per_doc")]
        public int? MaxTokensPerDoc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponseSamplingDefaults" /> class.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="k"></param>
        /// <param name="p"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="maxTokensPerDoc"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelResponseSamplingDefaults(
            float? temperature,
            int? k,
            float? p,
            float? frequencyPenalty,
            float? presencePenalty,
            int? maxTokensPerDoc)
        {
            this.Temperature = temperature;
            this.K = k;
            this.P = p;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.MaxTokensPerDoc = maxTokensPerDoc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponseSamplingDefaults" /> class.
        /// </summary>
        public GetModelResponseSamplingDefaults()
        {
        }

    }
}