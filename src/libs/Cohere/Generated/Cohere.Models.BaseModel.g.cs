
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// The base model used for fine-tuning.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class BaseModel
    {
        /// <summary>
        /// The name of the base model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Name { get; set; }

        /// <summary>
        /// read-only. The version of the base model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Version { get; set; }

        /// <summary>
        /// The type of the base model.<br/>
        /// Default Value: BASE_TYPE_UNSPECIFIED
        /// </summary>
        /// <default>global::Cohere.BaseType.Unspecified</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.BaseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::Cohere.BaseType BaseType { get; set; } = global::Cohere.BaseType.Unspecified;

        /// <summary>
        /// Deprecated: The fine-tuning strategy.<br/>
        /// Default Value: STRATEGY_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.StrategyJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Cohere.Strategy? Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the base model.
        /// </param>
        /// <param name="version">
        /// read-only. The version of the base model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="baseType">
        /// The type of the base model.<br/>
        /// Default Value: BASE_TYPE_UNSPECIFIED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseModel(
            global::Cohere.BaseType baseType,
            string? name,
            string? version)
        {
            this.BaseType = baseType;
            this.Name = name;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel" /> class.
        /// </summary>
        public BaseModel()
        {
        }
    }
}