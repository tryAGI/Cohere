
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Configuration for [reasoning features](https://docs.cohere.com/docs/reasoning).
    /// </summary>
    public sealed partial class Thinking
    {
        /// <summary>
        /// The maximum number of tokens the model can use for thinking, which must be set to a positive integer.<br/>
        /// The model will stop thinking if it reaches the thinking token budget and will proceed with the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_budget")]
        public int? TokenBudget { get; set; }

        /// <summary>
        /// Reasoning is enabled by default for models that support it, but can be turned off by setting `"type": "disabled"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ThinkingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ThinkingType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Thinking" /> class.
        /// </summary>
        /// <param name="tokenBudget">
        /// The maximum number of tokens the model can use for thinking, which must be set to a positive integer.<br/>
        /// The model will stop thinking if it reaches the thinking token budget and will proceed with the response.
        /// </param>
        /// <param name="type">
        /// Reasoning is enabled by default for models that support it, but can be turned off by setting `"type": "disabled"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Thinking(
            global::Cohere.ThinkingType type,
            int? tokenBudget)
        {
            this.Type = type;
            this.TokenBudget = tokenBudget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thinking" /> class.
        /// </summary>
        public Thinking()
        {
        }
    }
}