
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolPlanDeltaEventVariant2Delta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_plan")]
        public string? ToolPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolPlanDeltaEventVariant2Delta" /> class.
        /// </summary>
        /// <param name="toolPlan"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatToolPlanDeltaEventVariant2Delta(
            string? toolPlan)
        {
            this.ToolPlan = toolPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolPlanDeltaEventVariant2Delta" /> class.
        /// </summary>
        public ChatToolPlanDeltaEventVariant2Delta()
        {
        }
    }
}