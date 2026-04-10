#nullable enable

namespace Cohere
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Create a batch<br/>
        /// Creates and executes a batch from an uploaded dataset of requests
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.CreateBatchResponse> CreateAsync(

            global::Cohere.Batch request,
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Creates and executes a batch from an uploaded dataset of requests
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="name">
        /// Batch name (e.g. `foobar`).
        /// </param>
        /// <param name="inputDatasetId">
        /// ID of the dataset the batch reads inputs from.
        /// </param>
        /// <param name="model">
        /// The name of the model the batch uses.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.CreateBatchResponse> CreateAsync(
            string name,
            string inputDatasetId,
            string model,
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}