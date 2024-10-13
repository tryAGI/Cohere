using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/v2/docs/command-r), [Command R+](https://docs.cohere.com/v2/docs/command-r-plus) and newer models.<br/>
    /// The model can be forced into outputting JSON objects by setting `{ "type": "json_object" }`.<br/>
    /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
    /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
    /// **Note**: When `json_schema` is not specified, the generated object can have up to 5 layers of nesting.<br/>
    /// **Limitation**: The parameter is not supported when used in combinations with the `documents` or `tools` parameters.
    /// </summary>
    public readonly partial struct ResponseFormatV2 : global::System.IEquatable<ResponseFormatV2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.TextResponseFormatV2? Text { get; init; }
#else
        public global::Cohere.TextResponseFormatV2? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatV2(global::Cohere.TextResponseFormatV2 value) => new ResponseFormatV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.TextResponseFormatV2?(ResponseFormatV2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatV2(global::Cohere.TextResponseFormatV2? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.JsonResponseFormatV2? Json { get; init; }
#else
        public global::Cohere.JsonResponseFormatV2? Json { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Json))]
#endif
        public bool IsJson => Json != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatV2(global::Cohere.JsonResponseFormatV2 value) => new ResponseFormatV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.JsonResponseFormatV2?(ResponseFormatV2 @this) => @this.Json;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatV2(global::Cohere.JsonResponseFormatV2? value)
        {
            Json = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatV2(
            global::Cohere.TextResponseFormatV2? text,
            global::Cohere.JsonResponseFormatV2? json
            )
        {
            Text = text;
            Json = json;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Json as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJson || !IsText && IsJson;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.TextResponseFormatV2?, TResult>? text = null,
            global::System.Func<global::Cohere.JsonResponseFormatV2?, TResult>? json = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsJson && json != null)
            {
                return json(Json!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.TextResponseFormatV2?>? text = null,
            global::System.Action<global::Cohere.JsonResponseFormatV2?>? json = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsJson)
            {
                json?.Invoke(Json!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Cohere.TextResponseFormatV2),
                Json,
                typeof(global::Cohere.JsonResponseFormatV2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResponseFormatV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.TextResponseFormatV2?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.JsonResponseFormatV2?>.Default.Equals(Json, other.Json) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormatV2 obj1, ResponseFormatV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormatV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormatV2 obj1, ResponseFormatV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormatV2 o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Cohere.ResponseFormatV2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Cohere.ResponseFormatV2),
                jsonSerializerContext) as global::Cohere.ResponseFormatV2?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Cohere.ResponseFormatV2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Cohere.ResponseFormatV2>(
                json,
                jsonSerializerOptions);
        }

    }
}
