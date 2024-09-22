
#nullable enable

namespace Cohere
{
    public partial class DatasetsClient
    {
        partial void PrepareGetDatasetUsageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName);
        partial void PrepareGetDatasetUsageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName);
        partial void ProcessGetDatasetUsageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDatasetUsageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Dataset Usage<br/>
        /// View the dataset storage usage for your Organization. Each Organization can have up to 10GB of storage across all their users.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cohere.GetDatasetUsageResponse> GetDatasetUsageAsync(
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDatasetUsageArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName);

            if (xClientName != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-Client-Name", xClientName);
            }

            var __pathBuilder = new PathBuilder(
                path: "/v1/datasets/usage",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetDatasetUsageRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xClientName: xClientName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDatasetUsageResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDatasetUsageResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Cohere.GetDatasetUsageResponse), JsonSerializerContext) as global::Cohere.GetDatasetUsageResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}