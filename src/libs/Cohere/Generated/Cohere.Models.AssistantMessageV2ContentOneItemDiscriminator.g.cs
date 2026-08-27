
#nullable enable

namespace Cohere
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantMessageV2ContentOneItemDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.AssistantMessageV2ContentOneItemDiscriminatorTypeJsonConverter))]
        public global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageV2ContentOneItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageV2ContentOneItemDiscriminator(
            global::Cohere.AssistantMessageV2ContentOneItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageV2ContentOneItemDiscriminator" /> class.
        /// </summary>
        public AssistantMessageV2ContentOneItemDiscriminator()
        {
        }

    }
}