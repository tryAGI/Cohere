#nullable enable

namespace Cohere
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Models<br/>
        /// Returns a list of models available for use.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="endpoint">
        /// One of the Cohere API endpoints that the model can be used with.
        /// </param>
        /// <param name="defaultOnly"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.ListModelsResponse> ListAsync(
            double? pageSize = default,
            string? pageToken = default,
            global::Cohere.CompatibleEndpoint? endpoint = default,
            bool? defaultOnly = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}