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
    public readonly partial struct ResponseFormat2 : global::System.IEquatable<ResponseFormat2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.TextResponseFormat2? Text { get; init; }
#else
        public global::Cohere.TextResponseFormat2? Text { get; }
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
        public static implicit operator ResponseFormat2(global::Cohere.TextResponseFormat2 value) => new ResponseFormat2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.TextResponseFormat2?(ResponseFormat2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat2(global::Cohere.TextResponseFormat2? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.JSONResponseFormat2? JSON { get; init; }
#else
        public global::Cohere.JSONResponseFormat2? JSON { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSON))]
#endif
        public bool IsJSON => JSON != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormat2(global::Cohere.JSONResponseFormat2 value) => new ResponseFormat2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.JSONResponseFormat2?(ResponseFormat2 @this) => @this.JSON;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat2(global::Cohere.JSONResponseFormat2? value)
        {
            JSON = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat2(
            global::Cohere.TextResponseFormat2? text,
            global::Cohere.JSONResponseFormat2? jSON
            )
        {
            Text = text;
            JSON = jSON;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JSON as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJSON || !IsText && IsJSON;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Cohere.TextResponseFormat2),
                JSON,
                typeof(global::Cohere.JSONResponseFormat2),
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
        public bool Equals(ResponseFormat2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.TextResponseFormat2?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.JSONResponseFormat2?>.Default.Equals(JSON, other.JSON) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormat2 obj1, ResponseFormat2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormat2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormat2 obj1, ResponseFormat2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormat2 o && Equals(o);
        }
    }
}
