#nullable enable

namespace Cohere
{
    public partial interface IFinetuningClient
    {
        /// <summary>
        /// Updates a fine-tuned model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.UpdateFinetunedModelResponse> UpdateFinetunedModelAsync(
            string id,
            global::Cohere.UpdateFinetunedModelRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a fine-tuned model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="name">
        /// FinetunedModel name (e.g. `foobar`).
        /// </param>
        /// <param name="creatorId">
        /// User ID of the creator.
        /// </param>
        /// <param name="organizationId">
        /// Organization ID.
        /// </param>
        /// <param name="settings">
        /// The configuration used for fine-tuning.
        /// </param>
        /// <param name="status">
        /// The possible stages of a fine-tuned model life-cycle.<br/>
        ///  - STATUS_UNSPECIFIED: Unspecified status.<br/>
        ///  - STATUS_FINETUNING: The fine-tuned model is being fine-tuned.<br/>
        ///  - STATUS_DEPLOYING_API: The fine-tuned model is being deployed.<br/>
        ///  - STATUS_READY: The fine-tuned model is ready to receive requests.<br/>
        ///  - STATUS_FAILED: The fine-tuned model failed.<br/>
        ///  - STATUS_DELETED: The fine-tuned model was deleted.<br/>
        ///  - STATUS_TEMPORARILY_OFFLINE: The fine-tuned model is temporarily unavailable.<br/>
        ///  - STATUS_PAUSED: The fine-tuned model is paused (Vanilla only).<br/>
        ///  - STATUS_QUEUED: The fine-tuned model is queued for training.<br/>
        /// Default Value: STATUS_UNSPECIFIED
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp.
        /// </param>
        /// <param name="updatedAt">
        /// Latest update timestamp.
        /// </param>
        /// <param name="completedAt">
        /// Timestamp for the completed fine-tuning.
        /// </param>
        /// <param name="lastUsed">
        /// Timestamp for the latest request to this fine-tuned model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.UpdateFinetunedModelResponse> UpdateFinetunedModelAsync(
            string id,
            string name,
            global::Cohere.Settings settings,
            string? xClientName = default,
            string? creatorId = default,
            string? organizationId = default,
            global::Cohere.Status? status = global::Cohere.Status.STATUSUNSPECIFIED,
            global::System.DateTime createdAt = default,
            global::System.DateTime updatedAt = default,
            global::System.DateTime completedAt = default,
            global::System.DateTime lastUsed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}