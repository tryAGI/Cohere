
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A change in status of a fine-tuned model.
    /// </summary>
    public sealed partial class Event
    {
        /// <summary>
        /// ID of the user who initiated the event. Empty if initiated by the system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.StatusJsonConverter))]
        public global::Cohere.Status? Status { get; set; } = global::Cohere.Status.STATUSUNSPECIFIED;

        /// <summary>
        /// Timestamp when the event happened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}