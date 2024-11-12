#nullable enable

namespace Cohere
{
    public partial interface IConnectorsClient
    {
        /// <summary>
        /// Get a Connector<br/>
        /// Retrieve a connector by ID. See ['Connectors'](https://docs.cohere.com/docs/connectors) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.GetConnectorResponse> GetConnectorAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}