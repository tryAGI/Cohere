
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="billedUnits"></param>
        /// <param name="tokens"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Usage(
            global::Cohere.UsageBilledUnits? billedUnits,
            global::Cohere.UsageTokens? tokens)
        {
            this.BilledUnits = billedUnits;
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}