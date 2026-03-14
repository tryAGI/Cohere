
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Options for controlling citation generation.
    /// </summary>
    public sealed partial class CitationOptions
    {
        /// <summary>
        /// Defaults to `"enabled"`.<br/>
        /// Citations are enabled by default for models that support it, but can be turned off by setting `"type": "disabled"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.CitationOptionsModeJsonConverter))]
        public global::Cohere.CitationOptionsMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationOptions" /> class.
        /// </summary>
        /// <param name="mode">
        /// Defaults to `"enabled"`.<br/>
        /// Citations are enabled by default for models that support it, but can be turned off by setting `"type": "disabled"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CitationOptions(
            global::Cohere.CitationOptionsMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationOptions" /> class.
        /// </summary>
        public CitationOptions()
        {
        }
    }
}