
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The parameters of the function as a JSON schema.
    /// </summary>
    public sealed partial class ToolV2FunctionParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolV2FunctionParameters" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolV2FunctionParameters(
 )
        {
        }
    }
}