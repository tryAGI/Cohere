#nullable enable

namespace Cohere
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Returns a fine-tuned model by ID.<br/>
        /// Retrieve a fine-tuned model by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.GetFinetunedModelResponse> GetFinetunedModelAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}