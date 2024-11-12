
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The name and value of the parameters to use when invoking a tool.
    /// </summary>
    public sealed partial class ToolCallParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallParameters" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolCallParameters(
 )
        {
        }
    }
}