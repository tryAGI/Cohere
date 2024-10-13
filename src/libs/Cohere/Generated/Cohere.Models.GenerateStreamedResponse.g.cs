using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response in content type stream when `stream` is `true` in the request parameters. Generation tokens are streamed with the GenerationStream response. The final response is of type GenerationFinalResponse.
    /// </summary>
    public readonly partial struct GenerateStreamedResponse : global::System.IEquatable<GenerateStreamedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.GenerateStreamText? StreamText { get; init; }
#else
        public global::Cohere.GenerateStreamText? StreamText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamText))]
#endif
        public bool IsStreamText => StreamText != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamedResponse(global::Cohere.GenerateStreamText value) => new GenerateStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.GenerateStreamText?(GenerateStreamedResponse @this) => @this.StreamText;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(global::Cohere.GenerateStreamText? value)
        {
            StreamText = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.GenerateStreamEnd? StreamEnd { get; init; }
#else
        public global::Cohere.GenerateStreamEnd? StreamEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEnd))]
#endif
        public bool IsStreamEnd => StreamEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamedResponse(global::Cohere.GenerateStreamEnd value) => new GenerateStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.GenerateStreamEnd?(GenerateStreamedResponse @this) => @this.StreamEnd;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(global::Cohere.GenerateStreamEnd? value)
        {
            StreamEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.GenerateStreamError? StreamError { get; init; }
#else
        public global::Cohere.GenerateStreamError? StreamError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamError))]
#endif
        public bool IsStreamError => StreamError != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamedResponse(global::Cohere.GenerateStreamError value) => new GenerateStreamedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.GenerateStreamError?(GenerateStreamedResponse @this) => @this.StreamError;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(global::Cohere.GenerateStreamError? value)
        {
            StreamError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(
            global::Cohere.GenerateStreamText? streamText,
            global::Cohere.GenerateStreamEnd? streamEnd,
            global::Cohere.GenerateStreamError? streamError
            )
        {
            StreamText = streamText;
            StreamEnd = streamEnd;
            StreamError = streamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamError as object ??
            StreamEnd as object ??
            StreamText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamText && !IsStreamEnd && !IsStreamError || !IsStreamText && IsStreamEnd && !IsStreamError || !IsStreamText && !IsStreamEnd && IsStreamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.GenerateStreamText?, TResult>? streamText = null,
            global::System.Func<global::Cohere.GenerateStreamEnd?, TResult>? streamEnd = null,
            global::System.Func<global::Cohere.GenerateStreamError?, TResult>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamText && streamText != null)
            {
                return streamText(StreamText!);
            }
            else if (IsStreamEnd && streamEnd != null)
            {
                return streamEnd(StreamEnd!);
            }
            else if (IsStreamError && streamError != null)
            {
                return streamError(StreamError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.GenerateStreamText?>? streamText = null,
            global::System.Action<global::Cohere.GenerateStreamEnd?>? streamEnd = null,
            global::System.Action<global::Cohere.GenerateStreamError?>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamText)
            {
                streamText?.Invoke(StreamText!);
            }
            else if (IsStreamEnd)
            {
                streamEnd?.Invoke(StreamEnd!);
            }
            else if (IsStreamError)
            {
                streamError?.Invoke(StreamError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamText,
                typeof(global::Cohere.GenerateStreamText),
                StreamEnd,
                typeof(global::Cohere.GenerateStreamEnd),
                StreamError,
                typeof(global::Cohere.GenerateStreamError),
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
        public bool Equals(GenerateStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.GenerateStreamText?>.Default.Equals(StreamText, other.StreamText) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.GenerateStreamEnd?>.Default.Equals(StreamEnd, other.StreamEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.GenerateStreamError?>.Default.Equals(StreamError, other.StreamError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateStreamedResponse obj1, GenerateStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateStreamedResponse obj1, GenerateStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateStreamedResponse o && Equals(o);
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
        public static global::Cohere.GenerateStreamedResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Cohere.GenerateStreamedResponse),
                jsonSerializerContext) as global::Cohere.GenerateStreamedResponse?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Cohere.GenerateStreamedResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Cohere.GenerateStreamedResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
