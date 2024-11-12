
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A relevant documents that the model can cite to generate a more accurate reply. Each document is a string-string dictionary.
    /// </summary>
    public sealed partial class DocumentData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentData" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DocumentData(
 )
        {
        }
    }
}