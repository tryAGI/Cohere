#nullable enable

namespace Cohere
{
    public partial interface IConnectorsClient
    {
        /// <summary>
        /// Authorize with oAuth<br/>
        /// Authorize the connector with the given ID for the connector oauth app.  See ['Connector Authentication'](https://docs.cohere.com/docs/connector-authentication) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="afterTokenRedirect"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.OAuthAuthorizeResponse> OAuthAuthorizeConnectorAsync(
            string id,
            string? afterTokenRedirect = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}