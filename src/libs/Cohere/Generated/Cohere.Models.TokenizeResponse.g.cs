
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Cohere.ApiMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_strings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TokenStrings { get; set; }

        /// <summary>
        /// An array of tokens, where each token is an integer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse" /> class.
        /// </summary>
        /// <param name="meta"></param>
        /// <param name="tokenStrings"></param>
        /// <param name="tokens">
        /// An array of tokens, where each token is an integer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizeResponse(
            global::System.Collections.Generic.IList<string> tokenStrings,
            global::System.Collections.Generic.IList<int> tokens,
            global::Cohere.ApiMeta? meta)
        {
            this.TokenStrings = tokenStrings ?? throw new global::System.ArgumentNullException(nameof(tokenStrings));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse" /> class.
        /// </summary>
        public TokenizeResponse()
        {
        }
    }
}