
#nullable enable

namespace Cohere
{
    public partial class CohereApi
    {
        partial void PrepareSummarizeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::Cohere.SummarizeRequest request);
        partial void PrepareSummarizeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::Cohere.SummarizeRequest request);
        partial void ProcessSummarizeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSummarizeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Summarize<br/>
        /// &gt; 🚧 Warning<br/>
        /// &gt; <br/>
        /// &gt; This API is marked as "Legacy" and is no longer maintained. Follow the [migration guide](/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.<br/>
        /// Generates a summary in English for a given text.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cohere.SummarizeResponse> SummarizeAsync(
            string? xClientName,
            global::Cohere.SummarizeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSummarizeArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/summarize", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::Cohere.SourceGenerationContext.Default.SummarizeRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSummarizeRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xClientName: xClientName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSummarizeResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSummarizeResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::Cohere.SourceGenerationContext.Default.SummarizeResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Summarize<br/>
        /// &gt; 🚧 Warning<br/>
        /// &gt; <br/>
        /// &gt; This API is marked as "Legacy" and is no longer maintained. Follow the [migration guide](/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.<br/>
        /// Generates a summary in English for a given text.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="text">
        /// The text to generate a summary for. Can be up to 100,000 characters long. Currently the only supported language is English.
        /// </param>
        /// <param name="length">
        /// One of `short`, `medium`, `long`, or `auto` defaults to `auto`. Indicates the approximate length of the summary. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="format">
        /// One of `paragraph`, `bullets`, or `auto`, defaults to `auto`. Indicates the style in which the summary will be delivered - in a free form paragraph or in bullet points. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: paragraph
        /// </param>
        /// <param name="model">
        /// The identifier of the model to generate the summary with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental). Smaller, "light" models are faster, while larger models will perform better.
        /// </param>
        /// <param name="extractiveness">
        /// One of `low`, `medium`, `high`, or `auto`, defaults to `auto`. Controls how close to the original text the summary is. `high` extractiveness summaries will lean towards reusing sentences verbatim, while `low` extractiveness summaries will tend to paraphrase more. If `auto` is selected, the best option will be picked based on the input text.<br/>
        /// Default Value: low
        /// </param>
        /// <param name="temperature">
        /// Ranges from 0 to 5. Controls the randomness of the output. Lower values tend to generate more “predictable” output, while higher values tend to generate more “creative” output. The sweet spot is typically between 0 and 1.<br/>
        /// Default Value: 0.3
        /// </param>
        /// <param name="additionalCommand">
        /// A free-form instruction for modifying how the summaries get generated. Should complete the sentence "Generate a summary _". Eg. "focusing on the next steps" or "written by Yoda"
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cohere.SummarizeResponse> SummarizeAsync(
            string text,
            string? xClientName = default,
            global::Cohere.SummarizeRequestLength? length = global::Cohere.SummarizeRequestLength.Medium,
            global::Cohere.SummarizeRequestFormat? format = global::Cohere.SummarizeRequestFormat.Paragraph,
            string? model = default,
            global::Cohere.SummarizeRequestExtractiveness? extractiveness = global::Cohere.SummarizeRequestExtractiveness.Low,
            double temperature = 0.3,
            string? additionalCommand = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Cohere.SummarizeRequest
            {
                Text = text,
                Length = length,
                Format = format,
                Model = model,
                Extractiveness = extractiveness,
                Temperature = temperature,
                AdditionalCommand = additionalCommand,
            };

            return await SummarizeAsync(
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}