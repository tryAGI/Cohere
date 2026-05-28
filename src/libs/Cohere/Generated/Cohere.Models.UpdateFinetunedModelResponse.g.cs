
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response to a request to update a fine-tuned model.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class UpdateFinetunedModelResponse
    {
        /// <summary>
        /// Information about the fine-tuned model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetuned_model")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Cohere.FinetunedModel? FinetunedModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}