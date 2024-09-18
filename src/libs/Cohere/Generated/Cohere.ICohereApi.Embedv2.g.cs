#nullable enable

namespace Cohere
{
    public partial interface ICohereApi
    {
        /// <summary>
        /// Embed<br/>
        /// This endpoint returns text embeddings. An embedding is a list of floating point numbers that captures semantic information about the text that it represents.<br/>
        /// Embeddings can be used to create text classifiers as well as empower semantic search. To learn more about embeddings, see the embedding page.<br/>
        /// If you want to learn more how to use the embedding model, have a look at the [Semantic Search Guide](/docs/semantic-search).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.EmbedByTypeResponse> Embedv2Async(
            global::Cohere.V2EmbedRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Embed<br/>
        /// This endpoint returns text embeddings. An embedding is a list of floating point numbers that captures semantic information about the text that it represents.<br/>
        /// Embeddings can be used to create text classifiers as well as empower semantic search. To learn more about embeddings, see the embedding page.<br/>
        /// If you want to learn more how to use the embedding model, have a look at the [Semantic Search Guide](/docs/semantic-search).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.EmbedByTypeResponse> Embedv2Async(
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}