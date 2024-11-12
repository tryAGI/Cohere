
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolParameterDefinitions2
    {
        /// <summary>
        /// The description of the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type of the parameter. Must be a valid Python type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Denotes whether the parameter is always present (required) or not. Defaults to not required.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameterDefinitions2" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the parameter.
        /// </param>
        /// <param name="type">
        /// The type of the parameter. Must be a valid Python type.
        /// </param>
        /// <param name="required">
        /// Denotes whether the parameter is always present (required) or not. Defaults to not required.<br/>
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolParameterDefinitions2(
            string type,
            string? description,
            bool? required)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameterDefinitions2" /> class.
        /// </summary>
        public ToolParameterDefinitions2()
        {
        }
    }
}