#nullable enable

namespace Cohere
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// List batches<br/>
        /// List the batches for the current user
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="orderBy"></param>
        /// <param name="xClientName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.ListBatchesResponse> ListAsync(
            int? pageSize = default,
            string? pageToken = default,
            string? orderBy = default,
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}