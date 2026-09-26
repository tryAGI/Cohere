
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response from the v2 parse endpoint.
    /// </summary>
    public sealed partial class ParseResponse
    {
        /// <summary>
        /// Unique identifier for the parse response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Parsed pages in document order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cohere.ParsePage> Pages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Cohere.ApiMeta? Meta { get; set; }

        /// <summary>
        /// The reason parsing finished. For Parse, this is only ever `COMPLETE` or<br/>
        /// `MAX_TOKENS`; `MAX_TOKENS` indicates the output was truncated because it<br/>
        /// exceeded the maximum output token limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ChatFinishReasonJsonConverter))]
        public global::Cohere.ChatFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the parse response.
        /// </param>
        /// <param name="pages">
        /// Parsed pages in document order.
        /// </param>
        /// <param name="meta"></param>
        /// <param name="finishReason">
        /// The reason parsing finished. For Parse, this is only ever `COMPLETE` or<br/>
        /// `MAX_TOKENS`; `MAX_TOKENS` indicates the output was truncated because it<br/>
        /// exceeded the maximum output token limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseResponse(
            string id,
            global::System.Collections.Generic.IList<global::Cohere.ParsePage> pages,
            global::Cohere.ApiMeta? meta,
            global::Cohere.ChatFinishReason? finishReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Meta = meta;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResponse" /> class.
        /// </summary>
        public ParseResponse()
        {
        }

    }
}