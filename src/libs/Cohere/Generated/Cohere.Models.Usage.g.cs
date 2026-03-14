
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billed_units")]
        public global::Cohere.UsageBilledUnits? BilledUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::Cohere.UsageTokens? Tokens { get; set; }

        /// <summary>
        /// The number of prompt tokens that hit the inference cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="billedUnits"></param>
        /// <param name="tokens"></param>
        /// <param name="cachedTokens">
        /// The number of prompt tokens that hit the inference cache.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            global::Cohere.UsageBilledUnits? billedUnits,
            global::Cohere.UsageTokens? tokens,
            double? cachedTokens)
        {
            this.BilledUnits = billedUnits;
            this.Tokens = tokens;
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}