#nullable enable

namespace Cohere
{
    public partial interface IEmbedJobsClient
    {
        /// <summary>
        /// List Embed Jobs<br/>
        /// The list embed job endpoint allows users to view all embed jobs history for that specific user.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.ListEmbedJobResponse> ListEmbedJobsAsync(
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}