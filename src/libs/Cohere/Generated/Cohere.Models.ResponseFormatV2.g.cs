using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/docs/command-r), [Command R+](https://docs.cohere.com/docs/command-r-plus) and newer models.<br/>
    /// The model can be forced into outputting JSON objects (with up to 5 levels of nesting) by setting `{ "type": "json_object" }`.<br/>
    /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
    /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
    /// **Limitation**: The parameter is not supported in RAG mode (when any of `connectors`, `documents`, `tools`, `tool_results` are provided).
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
    }
}
