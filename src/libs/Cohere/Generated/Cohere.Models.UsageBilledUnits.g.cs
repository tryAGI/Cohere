
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageBilledUnits
    {
        /// <summary>
        /// The number of billed input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public double? InputTokens { get; set; }

        /// <summary>
        /// The number of billed output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// The number of billed search units.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_units")]
        public double? SearchUnits { get; set; }

        /// <summary>
        /// The number of billed classifications units.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifications")]
        public double? Classifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBilledUnits" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of billed input tokens.
        /// </param>
        /// <param name="outputTokens">
        /// The number of billed output tokens.
        /// </param>
        /// <param name="searchUnits">
        /// The number of billed search units.
        /// </param>
        /// <param name="classifications">
        /// The number of billed classifications units.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsageBilledUnits(
            double? inputTokens,
            double? outputTokens,
            double? searchUnits,
            double? classifications)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.SearchUnits = searchUnits;
            this.Classifications = classifications;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBilledUnits" /> class.
        /// </summary>
        public UsageBilledUnits()
        {
        }
    }
}