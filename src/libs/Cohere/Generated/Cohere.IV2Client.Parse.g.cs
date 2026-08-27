#nullable enable

namespace Cohere
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Parse API (v2)<br/>
        /// Parse a document image into structured output. Use `output_format` to select<br/>
        /// blocks or markdown (default).<br/>
        /// Currently supports `document.type = image_url` only (data URI or remote http(s)<br/>
        /// image URL). PDF / file URL inputs are not yet supported.<br/>
        /// Image limits: 20 MB file size; 50 megapixels or 200 MB decoded (whichever is<br/>
        /// exceeded first).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.ParseResponse> ParseAsync(

            global::Cohere.ParseRequest request,
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse API (v2)<br/>
        /// Parse a document image into structured output. Use `output_format` to select<br/>
        /// blocks or markdown (default).<br/>
        /// Currently supports `document.type = image_url` only (data URI or remote http(s)<br/>
        /// image URL). PDF / file URL inputs are not yet supported.<br/>
        /// Image limits: 20 MB file size; 50 megapixels or 200 MB decoded (whichever is<br/>
        /// exceeded first).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.AutoSDKHttpResponse<global::Cohere.ParseResponse>> ParseAsResponseAsync(

            global::Cohere.ParseRequest request,
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse API (v2)<br/>
        /// Parse a document image into structured output. Use `output_format` to select<br/>
        /// blocks or markdown (default).<br/>
        /// Currently supports `document.type = image_url` only (data URI or remote http(s)<br/>
        /// image URL). PDF / file URL inputs are not yet supported.<br/>
        /// Image limits: 20 MB file size; 50 megapixels or 200 MB decoded (whichever is<br/>
        /// exceeded first).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// The name of a compatible Cohere parse model.
        /// </param>
        /// <param name="document">
        /// Document to parse. Currently only `image_url` documents are supported.
        /// </param>
        /// <param name="outputFormat">
        /// Selects the page payload shape in the response. Defaults to `"markdown"`.<br/>
        /// - `"markdown"`: each page includes markdown content. Tables are inlined as<br/>
        ///   HTML, and images are referenced as `![&lt;description&gt;](&lt;image_id&gt;)` with<br/>
        ///   matching entries in `page.markdown.images`.<br/>
        /// - `"blocks"`: each page includes an ordered `blocks` array of text, image,<br/>
        ///   and table content regions, including bounding boxes where available.<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.ParseResponse> ParseAsync(
            string model,
            global::Cohere.ParseDocument document,
            string? xClientName = default,
            global::Cohere.ParseOutputFormat? outputFormat = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}