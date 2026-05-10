
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response to a request to list batches.
    /// </summary>
    public sealed partial class ListBatchesResponse
    {
        /// <summary>
        /// The batches that belong to the authenticated user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batches")]
        public global::System.Collections.Generic.IList<global::Cohere.Batch>? Batches { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page.<br/>
        /// If this field is omitted, there are no subsequent pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchesResponse" /> class.
        /// </summary>
        /// <param name="batches">
        /// The batches that belong to the authenticated user.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page.<br/>
        /// If this field is omitted, there are no subsequent pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBatchesResponse(
            global::System.Collections.Generic.IList<global::Cohere.Batch>? batches,
            string? nextPageToken)
        {
            this.Batches = batches;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchesResponse" /> class.
        /// </summary>
        public ListBatchesResponse()
        {
        }

    }
}