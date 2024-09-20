
#nullable enable

namespace Cohere
{
    public partial class ConnectorsClient
    {
        partial void PrepareOAuthAuthorizeConnectorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string? afterTokenRedirect,
            ref string? xClientName);
        partial void PrepareOAuthAuthorizeConnectorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string? afterTokenRedirect,
            string? xClientName);
        partial void ProcessOAuthAuthorizeConnectorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOAuthAuthorizeConnectorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Authorize with oAuth<br/>
        /// Authorize the connector with the given ID for the connector oauth app.  See ['Connector Authentication'](https://docs.cohere.com/docs/connector-authentication) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="afterTokenRedirect"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cohere.OAuthAuthorizeResponse> OAuthAuthorizeConnectorAsync(
            string id,
            string? afterTokenRedirect = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOAuthAuthorizeConnectorArguments(
                httpClient: _httpClient,
                id: ref id,
                afterTokenRedirect: ref afterTokenRedirect,
                xClientName: ref xClientName);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/connectors/{id}/oauth/authorize",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("after_token_redirect", afterTokenRedirect) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOAuthAuthorizeConnectorRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                afterTokenRedirect: afterTokenRedirect,
                xClientName: xClientName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOAuthAuthorizeConnectorResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOAuthAuthorizeConnectorResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Cohere.OAuthAuthorizeResponse), JsonSerializerContext) as global::Cohere.OAuthAuthorizeResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}