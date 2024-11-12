
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response to request to delete a fine-tuned model.
    /// </summary>
    public sealed partial class DeleteFinetunedModelResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFinetunedModelResponse" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeleteFinetunedModelResponse(
 )
        {
        }
    }
}