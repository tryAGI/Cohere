
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response to request to create a batch.
    /// </summary>
    public sealed partial class CreateBatchResponse
    {
        /// <summary>
        /// Information about the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.Batch Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchResponse" /> class.
        /// </summary>
        /// <param name="batch">
        /// Information about the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchResponse(
            global::Cohere.Batch batch)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchResponse" /> class.
        /// </summary>
        public CreateBatchResponse()
        {
        }
    }
}