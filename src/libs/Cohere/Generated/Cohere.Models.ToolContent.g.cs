using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A content block which contains information about the content of a tool result
    /// </summary>
    public readonly partial struct ToolContent : global::System.IEquatable<ToolContent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ToolContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Text content of the message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.TextContent? Text { get; init; }
#else
        public global::Cohere.TextContent? Text { get; }
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
        public static implicit operator ToolContent(global::Cohere.TextContent value) => new ToolContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.TextContent?(ToolContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ToolContent(global::Cohere.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// Document content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.DocumentContent? Document { get; init; }
#else
        public global::Cohere.DocumentContent? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolContent(global::Cohere.DocumentContent value) => new ToolContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.DocumentContent?(ToolContent @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public ToolContent(global::Cohere.DocumentContent? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolContent(
            global::Cohere.ToolContentDiscriminatorType? type,
            global::Cohere.TextContent? text,
            global::Cohere.DocumentContent? document
            )
        {
            Type = type;

            Text = text;
            Document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Document as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsDocument || !IsText && IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.TextContent?, TResult>? text = null,
            global::System.Func<global::Cohere.DocumentContent?, TResult>? document = null,
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
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.TextContent?>? text = null,
            global::System.Action<global::Cohere.DocumentContent?>? document = null,
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
            else if (IsDocument)
            {
                document?.Invoke(Document!);
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
                typeof(global::Cohere.TextContent),
                Document,
                typeof(global::Cohere.DocumentContent),
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
        public bool Equals(ToolContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.DocumentContent?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolContent obj1, ToolContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolContent obj1, ToolContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolContent o && Equals(o);
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
        public static global::Cohere.ToolContent? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Cohere.ToolContent),
                jsonSerializerContext) as global::Cohere.ToolContent?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Cohere.ToolContent? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Cohere.ToolContent>(
                json,
                jsonSerializerOptions);
        }

    }
}
