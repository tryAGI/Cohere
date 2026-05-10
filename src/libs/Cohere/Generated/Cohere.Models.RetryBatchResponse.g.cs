
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response to a request to retry a batch.
    /// </summary>
    public sealed partial class RetryBatchResponse
    {
        /// <summary>
        /// Information about the newly created retry batch.
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
        /// Initializes a new instance of the <see cref="RetryBatchResponse" /> class.
        /// </summary>
        /// <param name="batch">
        /// Information about the newly created retry batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetryBatchResponse(
            global::Cohere.Batch batch)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryBatchResponse" /> class.
        /// </summary>
        public RetryBatchResponse()
        {
        }

    }
}