#nullable enable

namespace Cohere
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Fetch history of statuses for a fine-tuned model.<br/>
        /// Returns a list of events that occurred during the life-cycle of the fine-tuned model.<br/>
        /// The events are ordered by creation time, with the most recent event first.<br/>
        /// The list can be paginated using `page_size` and `page_token` parameters.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="orderBy"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.ListEventsResponse> ListEventsAsync(
            string finetunedModelId,
            int? pageSize = default,
            string? pageToken = default,
            string? orderBy = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}