
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response to a request to list events of a fine-tuned model.
    /// </summary>
    public sealed partial class ListEventsResponse
    {
        /// <summary>
        /// List of events for the fine-tuned model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Cohere.Event>? Events { get; set; }

        /// <summary>
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total count of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventsResponse" /> class.
        /// </summary>
        /// <param name="events">
        /// List of events for the fine-tuned model.
        /// </param>
        /// <param name="nextPageToken">
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </param>
        /// <param name="totalSize">
        /// Total count of results.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListEventsResponse(
            global::System.Collections.Generic.IList<global::Cohere.Event>? events,
            string? nextPageToken,
            int? totalSize)
        {
            this.Events = events;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventsResponse" /> class.
        /// </summary>
        public ListEventsResponse()
        {
        }
    }
}