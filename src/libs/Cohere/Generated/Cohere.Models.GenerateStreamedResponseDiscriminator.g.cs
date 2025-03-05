
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamedResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeJsonConverter))]
        public global::Cohere.GenerateStreamedResponseDiscriminatorEventType? EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamedResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateStreamedResponseDiscriminator(
            global::Cohere.GenerateStreamedResponseDiscriminatorEventType? eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamedResponseDiscriminator" /> class.
        /// </summary>
        public GenerateStreamedResponseDiscriminator()
        {
        }
    }
}