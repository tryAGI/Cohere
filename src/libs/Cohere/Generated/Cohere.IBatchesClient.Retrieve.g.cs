#nullable enable

namespace Cohere
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Retrieve a batch<br/>
        /// Retrieves a batch
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.GetBatchResponse> RetrieveAsync(
            string id,
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}