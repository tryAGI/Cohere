
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetokenizeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Cohere.ApiMeta? Meta { get; set; }

        /// <summary>
        /// A string representing the list of tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeResponse" /> class.
        /// </summary>
        /// <param name="meta"></param>
        /// <param name="text">
        /// A string representing the list of tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetokenizeResponse(
            string text,
            global::Cohere.ApiMeta? meta)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeResponse" /> class.
        /// </summary>
        public DetokenizeResponse()
        {
        }
    }
}