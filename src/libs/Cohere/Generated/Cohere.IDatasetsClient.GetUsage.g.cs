#nullable enable

namespace Cohere
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get Dataset Usage<br/>
        /// View the dataset storage usage for your Organization. Each Organization can have up to 10GB of storage across all their users.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.DatasetsGetUsageResponse> GetUsageAsync(
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dataset Usage<br/>
        /// View the dataset storage usage for your Organization. Each Organization can have up to 10GB of storage across all their users.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.AutoSDKHttpResponse<global::Cohere.DatasetsGetUsageResponse>> GetUsageAsResponseAsync(
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}