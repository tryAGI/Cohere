
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Thinking gives the model enhanced reasoning capabilities for complex tasks, while also providing transparency into its step-by-step thought process before it delivers its final answer.<br/>
    /// When thinking is turned on, the model creates thinking content blocks where it outputs its internal reasoning. The model will incorporate insights from this reasoning before crafting a final response.<br/>
    /// When thinking is used without tools, the API response will include both thinking and text content blocks. Meanwhile, when thinking is used alongside tools and the model makes tool calls, the API response will include the thinking content block and `tool_calls`.
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
        /// 
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
        /// <param name="type"></param>
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