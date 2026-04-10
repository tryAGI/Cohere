#nullable enable

namespace Cohere
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Rerank API (v2)<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.V2RerankResponse> Rerank2Async(

            global::Cohere.V2RerankRequest request,
            string? xClientName = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank API (v2)<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// The identifier of the model to use, eg `rerank-v3.5`.
        /// </param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="documents">
        /// A list of texts that will be compared to the `query`.<br/>
        /// For optimal performance we recommend against sending more than 1,000 documents in a single request.<br/>
        /// **Note**: long documents will automatically be truncated to the value of `max_tokens_per_doc`.<br/>
        /// **Note**: structured data should be formatted as YAML strings for best performance.
        /// </param>
        /// <param name="topN">
        /// Limits the number of returned rerank results to the specified value. If not passed, all the rerank results will be returned.
        /// </param>
        /// <param name="maxTokensPerDoc">
        /// Defaults to `4096`. Long documents will be automatically truncated to the specified number of tokens.
        /// </param>
        /// <param name="priority">
        /// Controls how early the request is handled. Lower numbers indicate higher priority (default: 0, the highest). When the system is under load, higher-priority requests are processed first and are the least likely to be dropped.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.V2RerankResponse> Rerank2Async(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            string? xClientName = default,
            int? topN = default,
            int? maxTokensPerDoc = default,
            int? priority = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}