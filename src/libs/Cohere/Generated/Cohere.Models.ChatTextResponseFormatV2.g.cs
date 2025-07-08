
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatTextResponseFormatV2
    {
        /// <summary>
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ResponseFormatTypeV2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ResponseFormatTypeV2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTextResponseFormatV2" /> class.
        /// </summary>
        /// <param name="type">
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatTextResponseFormatV2(
            global::Cohere.ResponseFormatTypeV2 type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTextResponseFormatV2" /> class.
        /// </summary>
        public ChatTextResponseFormatV2()
        {
        }
    }
}