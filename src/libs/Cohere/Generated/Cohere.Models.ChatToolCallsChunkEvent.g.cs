#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatToolCallsChunkEvent : global::System.IEquatable<ChatToolCallsChunkEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamEvent? Stream { get; init; }
#else
        public global::Cohere.ChatStreamEvent? Stream { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stream))]
#endif
        public bool IsStream => Stream != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStream(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatStreamEvent? value)
        {
            value = Stream;
            return IsStream;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallsChunkEventT7lliu? T7lliu { get; init; }
#else
        public global::Cohere.ChatToolCallsChunkEventT7lliu? T7lliu { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(T7lliu))]
#endif
        public bool IsT7lliu => T7lliu != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickT7lliu(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatToolCallsChunkEventT7lliu? value)
        {
            value = T7lliu;
            return IsT7lliu;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallsChunkEvent(global::Cohere.ChatStreamEvent value) => new ChatToolCallsChunkEvent((global::Cohere.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEvent?(ChatToolCallsChunkEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsChunkEvent(global::Cohere.ChatStreamEvent? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallsChunkEvent(global::Cohere.ChatToolCallsChunkEventT7lliu value) => new ChatToolCallsChunkEvent((global::Cohere.ChatToolCallsChunkEventT7lliu?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallsChunkEventT7lliu?(ChatToolCallsChunkEvent @this) => @this.T7lliu;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsChunkEvent(global::Cohere.ChatToolCallsChunkEventT7lliu? value)
        {
            T7lliu = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsChunkEvent(
            global::Cohere.ChatStreamEvent? stream,
            global::Cohere.ChatToolCallsChunkEventT7lliu? t7lliu
            )
        {
            Stream = stream;
            T7lliu = t7lliu;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            T7lliu as object ??
            Stream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            T7lliu?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsT7lliu;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatStreamEvent, TResult>? stream = null,
            global::System.Func<global::Cohere.ChatToolCallsChunkEventT7lliu, TResult>? t7lliu = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStream && stream != null)
            {
                return stream(Stream!);
            }
            else if (IsT7lliu && t7lliu != null)
            {
                return t7lliu(T7lliu!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatStreamEvent>? stream = null,

            global::System.Action<global::Cohere.ChatToolCallsChunkEventT7lliu>? t7lliu = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStream)
            {
                stream?.Invoke(Stream!);
            }
            else if (IsT7lliu)
            {
                t7lliu?.Invoke(T7lliu!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatStreamEvent>? stream = null,
            global::System.Action<global::Cohere.ChatToolCallsChunkEventT7lliu>? t7lliu = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStream)
            {
                stream?.Invoke(Stream!);
            }
            else if (IsT7lliu)
            {
                t7lliu?.Invoke(T7lliu!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Stream,
                typeof(global::Cohere.ChatStreamEvent),
                T7lliu,
                typeof(global::Cohere.ChatToolCallsChunkEventT7lliu),
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
        public bool Equals(ChatToolCallsChunkEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEvent?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallsChunkEventT7lliu?>.Default.Equals(T7lliu, other.T7lliu) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolCallsChunkEvent obj1, ChatToolCallsChunkEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolCallsChunkEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolCallsChunkEvent obj1, ChatToolCallsChunkEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolCallsChunkEvent o && Equals(o);
        }
    }
}
