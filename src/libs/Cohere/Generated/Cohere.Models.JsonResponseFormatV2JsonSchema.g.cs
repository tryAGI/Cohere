
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A [JSON schema](https://json-schema.org/overview/what-is-jsonschema) object that the output will adhere to. There are some restrictions we have on the schema, refer to [our guide](/docs/structured-outputs-json#schema-constraints) for more information.<br/>
    /// Example (required name and age object):<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "type": "object",<br/>
    ///   "properties": {<br/>
    ///     "name": {"type": "string"},<br/>
    ///     "age": {"type": "integer"}<br/>
    ///   },<br/>
    ///   "required": ["name", "age"]<br/>
    /// }<br/>
    /// ```<br/>
    /// **Note**: This field must not be specified when the `type` is set to `"text"`.
    /// </summary>
    public sealed partial class JsonResponseFormatV2JsonSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::Cohere.JsonResponseFormatV2JsonSchema? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Cohere.JsonResponseFormatV2JsonSchema),
                jsonSerializerContext) as global::Cohere.JsonResponseFormatV2JsonSchema;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Cohere.JsonResponseFormatV2JsonSchema? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Cohere.JsonResponseFormatV2JsonSchema>(
                json,
                jsonSerializerOptions);
        }

    }
}