
#nullable enable

namespace Cohere
{
    /// <summary>
    /// This resource represents a fine-tuned model.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class FinetunedModel
    {
        /// <summary>
        /// read-only. FinetunedModel ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Id { get; set; }

        /// <summary>
        /// FinetunedModel name (e.g. `foobar`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Name { get; set; }

        /// <summary>
        /// read-only. User ID of the creator.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// read-only. Organization ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// FinetunedModel settings such as dataset, hyperparameters...
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::Cohere.Settings Settings { get; set; }

        /// <summary>
        /// read-only. Current stage in the life-cycle of the fine-tuned model.<br/>
        /// Default Value: STATUS_UNSPECIFIED<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.StatusJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Cohere.Status? Status { get; set; }

        /// <summary>
        /// read-only. Creation timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// read-only. Latest update timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// read-only. Timestamp for the completed fine-tuning.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// read-only. Deprecated: Timestamp for the latest request to this fine-tuned model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? LastUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModel" /> class.
        /// </summary>
        /// <param name="id">
        /// read-only. FinetunedModel ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// FinetunedModel name (e.g. `foobar`).
        /// </param>
        /// <param name="creatorId">
        /// read-only. User ID of the creator.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="organizationId">
        /// read-only. Organization ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="settings">
        /// FinetunedModel settings such as dataset, hyperparameters...
        /// </param>
        /// <param name="createdAt">
        /// read-only. Creation timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// read-only. Latest update timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completedAt">
        /// read-only. Timestamp for the completed fine-tuning.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastUsed">
        /// read-only. Deprecated: Timestamp for the latest request to this fine-tuned model.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetunedModel(
            string name,
            global::Cohere.Settings settings,
            string? id,
            string? creatorId,
            string? organizationId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? completedAt,
            global::System.DateTime? lastUsed)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Id = id;
            this.CreatorId = creatorId;
            this.OrganizationId = organizationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.LastUsed = lastUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModel" /> class.
        /// </summary>
        public FinetunedModel()
        {
        }
    }
}