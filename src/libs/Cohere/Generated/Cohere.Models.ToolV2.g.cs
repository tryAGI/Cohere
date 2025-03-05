
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolV2
    {
        /// <summary>
        /// The function to be executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::Cohere.ToolV2Function? Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ToolV2TypeJsonConverter))]
        public global::Cohere.ToolV2Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolV2" /> class.
        /// </summary>
        /// <param name="function">
        /// The function to be executed.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolV2(
            global::Cohere.ToolV2Function? function,
            global::Cohere.ToolV2Type? type)
        {
            this.Function = function;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolV2" /> class.
        /// </summary>
        public ToolV2()
        {
        }
    }
}