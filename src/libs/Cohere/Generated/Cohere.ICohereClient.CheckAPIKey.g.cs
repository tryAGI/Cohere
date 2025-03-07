#nullable enable

namespace Cohere
{
    public partial interface ICohereClient
    {
        /// <summary>
        /// Check API key<br/>
        /// Checks that the api key in the Authorization header is valid and active
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.CheckAPIKeyResponse> CheckAPIKeyAsync(
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}