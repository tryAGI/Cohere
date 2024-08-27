
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// The name of the tool to be called. Valid names contain only the characters `a-z`, `A-Z`, `0-9`, `_` and must not begin with a digit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of what the tool does, the model uses the description to choose when and how to call the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The input parameters of the tool. Accepts a dictionary where the key is the name of the parameter and the value is the parameter spec. Valid parameter names contain only the characters `a-z`, `A-Z`, `0-9`, `_` and must not begin with a digit.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "my_param": {<br/>
        ///     "description": &lt;string&gt;,<br/>
        ///     "type": &lt;string&gt;, // any python data type, such as 'str', 'bool'<br/>
        ///     "required": &lt;boolean&gt;<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_definitions")]
        public global::Cohere.ToolParameterDefinitions? ParameterDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}