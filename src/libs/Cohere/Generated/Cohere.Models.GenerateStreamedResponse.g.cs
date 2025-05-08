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
        public global::Cohere.GenerateStreamedResponseDiscriminatorEventType? EventType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.GenerateStreamText? TextGeneration { get; init; }
#else
        public global::Cohere.GenerateStreamText? TextGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGeneration))]
#endif
        public bool IsTextGeneration => TextGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamedResponse(global::Cohere.GenerateStreamText value) => new GenerateStreamedResponse((global::Cohere.GenerateStreamText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.GenerateStreamText?(GenerateStreamedResponse @this) => @this.TextGeneration;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamedResponse(global::Cohere.GenerateStreamText? value)
        {
            TextGeneration = value;
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
        public static implicit operator GenerateStreamedResponse(global::Cohere.GenerateStreamEnd value) => new GenerateStreamedResponse((global::Cohere.GenerateStreamEnd?)value);

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
        public static implicit operator GenerateStreamedResponse(global::Cohere.GenerateStreamError value) => new GenerateStreamedResponse((global::Cohere.GenerateStreamError?)value);

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
            global::Cohere.GenerateStreamedResponseDiscriminatorEventType? eventType,
            global::Cohere.GenerateStreamText? textGeneration,
            global::Cohere.GenerateStreamEnd? streamEnd,
            global::Cohere.GenerateStreamError? streamError
            )
        {
            EventType = eventType;

            TextGeneration = textGeneration;
            StreamEnd = streamEnd;
            StreamError = streamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamError as object ??
            StreamEnd as object ??
            TextGeneration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextGeneration?.ToString() ??
            StreamEnd?.ToString() ??
            StreamError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextGeneration && !IsStreamEnd && !IsStreamError || !IsTextGeneration && IsStreamEnd && !IsStreamError || !IsTextGeneration && !IsStreamEnd && IsStreamError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.GenerateStreamText?, TResult>? textGeneration = null,
            global::System.Func<global::Cohere.GenerateStreamEnd?, TResult>? streamEnd = null,
            global::System.Func<global::Cohere.GenerateStreamError?, TResult>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextGeneration && textGeneration != null)
            {
                return textGeneration(TextGeneration!);
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
            global::System.Action<global::Cohere.GenerateStreamText?>? textGeneration = null,
            global::System.Action<global::Cohere.GenerateStreamEnd?>? streamEnd = null,
            global::System.Action<global::Cohere.GenerateStreamError?>? streamError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextGeneration)
            {
                textGeneration?.Invoke(TextGeneration!);
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
                TextGeneration,
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

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(GenerateStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.GenerateStreamText?>.Default.Equals(TextGeneration, other.TextGeneration) &&
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
    }
}
