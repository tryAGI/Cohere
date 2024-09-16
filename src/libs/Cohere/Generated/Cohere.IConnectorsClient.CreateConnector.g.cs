#nullable enable

namespace Cohere
{
    public partial interface IConnectorsClient
    {
        /// <summary>
        /// Create a Connector<br/>
        /// Creates a new connector. The connector is tested during registration and will cancel registration when the test is unsuccessful. See ['Creating and Deploying a Connector'](https://docs.cohere.com/docs/creating-and-deploying-a-connector) for more information.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.CreateConnectorResponse> CreateConnectorAsync(
            global::Cohere.CreateConnectorRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Connector<br/>
        /// Creates a new connector. The connector is tested during registration and will cancel registration when the test is unsuccessful. See ['Creating and Deploying a Connector'](https://docs.cohere.com/docs/creating-and-deploying-a-connector) for more information.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="name">
        /// A human-readable name for the connector.
        /// </param>
        /// <param name="description">
        /// A description of the connector.
        /// </param>
        /// <param name="url">
        /// The URL of the connector that will be used to search for documents.
        /// </param>
        /// <param name="excludes">
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </param>
        /// <param name="oauth"></param>
        /// <param name="active">
        /// Whether the connector is active or not.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="continueOnFailure">
        /// Whether a chat request should continue or not if the request to this connector fails.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="serviceAuth"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.CreateConnectorResponse> CreateConnectorAsync(
            string name,
            string url,
            string? xClientName = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? excludes = default,
            global::Cohere.CreateConnectorOAuth? oauth = default,
            bool active = true,
            bool continueOnFailure = false,
            global::Cohere.CreateConnectorServiceAuth? serviceAuth = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}