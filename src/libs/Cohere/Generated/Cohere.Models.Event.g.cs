
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A change in status of a fine-tuned model.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class Event
    {
        /// <summary>
        /// ID of the user who initiated the event. Empty if initiated by the system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? UserId { get; set; }

        /// <summary>
        /// Status of the fine-tuned model.<br/>
        /// Default Value: STATUS_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.StatusJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Cohere.Status? Status { get; set; }

        /// <summary>
        /// Timestamp when the event happened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the user who initiated the event. Empty if initiated by the system.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event happened.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Event(
            string? userId,
            global::System.DateTime? createdAt)
        {
            this.UserId = userId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
        }
    }
}