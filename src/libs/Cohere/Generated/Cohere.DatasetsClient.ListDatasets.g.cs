
#nullable enable

namespace Cohere
{
    public partial class DatasetsClient
    {
        partial void PrepareListDatasetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? datasetType,
            ref global::System.DateTime before,
            ref global::System.DateTime after,
            ref double limit,
            ref double offset,
            ref global::Cohere.DatasetValidationStatus? validationStatus,
            ref string? xClientName);
        partial void PrepareListDatasetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? datasetType,
            global::System.DateTime before,
            global::System.DateTime after,
            double limit,
            double offset,
            global::Cohere.DatasetValidationStatus? validationStatus,
            string? xClientName);
        partial void ProcessListDatasetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListDatasetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Datasets<br/>
        /// List datasets that have been created.
        /// </summary>
        /// <param name="datasetType"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="validationStatus">
        /// The validation status of the dataset
        /// </param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cohere.ListDatasetsResponse> ListDatasetsAsync(
            string? datasetType = default,
            global::System.DateTime before = default,
            global::System.DateTime after = default,
            double limit = default,
            double offset = default,
            global::Cohere.DatasetValidationStatus? validationStatus = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListDatasetsArguments(
                httpClient: _httpClient,
                datasetType: ref datasetType,
                before: ref before,
                after: ref after,
                limit: ref limit,
                offset: ref offset,
                validationStatus: ref validationStatus,
                xClientName: ref xClientName);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/datasets?datasetType={datasetType}&before={before:yyyy-MM-ddTHH:mm:ssZ}&after={after:yyyy-MM-ddTHH:mm:ssZ}&limit={limit}&offset={offset}&validationStatus={(global::System.Uri.EscapeDataString(validationStatus?.ToValueString() ?? string.Empty))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListDatasetsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetType: datasetType,
                before: before,
                after: after,
                limit: limit,
                offset: offset,
                validationStatus: validationStatus,
                xClientName: xClientName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListDatasetsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListDatasetsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Cohere.ListDatasetsResponse), JsonSerializerContext) as global::Cohere.ListDatasetsResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}