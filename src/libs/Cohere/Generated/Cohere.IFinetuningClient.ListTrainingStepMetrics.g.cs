#nullable enable

namespace Cohere
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Retrieve training metrics for fine-tuned models.<br/>
        /// Returns a list of metrics measured during the training of a fine-tuned model.<br/>
        /// The metrics are ordered by step number, with the most recent step first.<br/>
        /// The list can be paginated using `page_size` and `page_token` parameters.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.ListTrainingStepMetricsResponse> ListTrainingStepMetricsAsync(
            string finetunedModelId,
            int? pageSize = default,
            string? pageToken = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}