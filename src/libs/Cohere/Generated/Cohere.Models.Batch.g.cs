
#nullable enable

namespace Cohere
{
    /// <summary>
    /// This resource represents a batch job.
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// read-only. Batch ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Batch name (e.g. `foobar`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// read-only. User ID of the creator.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// read-only. Organization ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// read-only. Current stage in the life-cycle of the batch.<br/>
        /// Default Value: BATCH_STATUS_UNSPECIFIED<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.BatchStatusJsonConverter))]
        public global::Cohere.BatchStatus? Status { get; set; }

        /// <summary>
        /// read-only. Creation timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// read-only. Latest update timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// ID of the dataset the batch reads inputs from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputDatasetId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dataset_id")]
        public string? OutputDatasetId { get; set; }

        /// <summary>
        /// read-only. The total number of input tokens in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public string? InputTokens { get; set; }

        /// <summary>
        /// read-only. The total number of output tokens in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public string? OutputTokens { get; set; }

        /// <summary>
        /// The name of the model the batch uses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// read-only. The total number of records in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_records")]
        public int? NumRecords { get; set; }

        /// <summary>
        /// read-only. The current number of successful records in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_successful_records")]
        public int? NumSuccessfulRecords { get; set; }

        /// <summary>
        /// read-only. The current number of failed records in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_failed_records")]
        public int? NumFailedRecords { get; set; }

        /// <summary>
        /// read-only. More details about the reason for the status of a batch job.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_reason")]
        public string? StatusReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="name">
        /// Batch name (e.g. `foobar`).
        /// </param>
        /// <param name="inputDatasetId">
        /// ID of the dataset the batch reads inputs from.
        /// </param>
        /// <param name="model">
        /// The name of the model the batch uses.
        /// </param>
        /// <param name="id">
        /// read-only. Batch ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorId">
        /// read-only. User ID of the creator.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="orgId">
        /// read-only. Organization ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// read-only. Current stage in the life-cycle of the batch.<br/>
        /// Default Value: BATCH_STATUS_UNSPECIFIED<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// read-only. Creation timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// read-only. Latest update timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputDatasetId">
        /// Included only in responses
        /// </param>
        /// <param name="inputTokens">
        /// read-only. The total number of input tokens in the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputTokens">
        /// read-only. The total number of output tokens in the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="numRecords">
        /// read-only. The total number of records in the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="numSuccessfulRecords">
        /// read-only. The current number of successful records in the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="numFailedRecords">
        /// read-only. The current number of failed records in the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="statusReason">
        /// read-only. More details about the reason for the status of a batch job.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Batch(
            string name,
            string inputDatasetId,
            string model,
            string? id,
            string? creatorId,
            string? orgId,
            global::Cohere.BatchStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? outputDatasetId,
            string? inputTokens,
            string? outputTokens,
            int? numRecords,
            int? numSuccessfulRecords,
            int? numFailedRecords,
            string? statusReason)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatorId = creatorId;
            this.OrgId = orgId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.InputDatasetId = inputDatasetId ?? throw new global::System.ArgumentNullException(nameof(inputDatasetId));
            this.OutputDatasetId = outputDatasetId;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.NumRecords = numRecords;
            this.NumSuccessfulRecords = numSuccessfulRecords;
            this.NumFailedRecords = numFailedRecords;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        public Batch()
        {
        }
    }
}