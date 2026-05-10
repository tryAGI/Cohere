#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatToolCallsGenerationEvent : global::System.IEquatable<ChatToolCallsGenerationEvent>
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
        public global::Cohere.ChatToolCallsGenerationEventNykiww? Nykiww { get; init; }
#else
        public global::Cohere.ChatToolCallsGenerationEventNykiww? Nykiww { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Nykiww))]
#endif
        public bool IsNykiww => Nykiww != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNykiww(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatToolCallsGenerationEventNykiww? value)
        {
            value = Nykiww;
            return IsNykiww;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallsGenerationEvent(global::Cohere.ChatStreamEvent value) => new ChatToolCallsGenerationEvent((global::Cohere.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEvent?(ChatToolCallsGenerationEvent @this) => @this.Stream;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsGenerationEvent(global::Cohere.ChatStreamEvent? value)
        {
            Stream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolCallsGenerationEvent FromStream(global::Cohere.ChatStreamEvent? value) => new ChatToolCallsGenerationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallsGenerationEvent(global::Cohere.ChatToolCallsGenerationEventNykiww value) => new ChatToolCallsGenerationEvent((global::Cohere.ChatToolCallsGenerationEventNykiww?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallsGenerationEventNykiww?(ChatToolCallsGenerationEvent @this) => @this.Nykiww;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsGenerationEvent(global::Cohere.ChatToolCallsGenerationEventNykiww? value)
        {
            Nykiww = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolCallsGenerationEvent FromNykiww(global::Cohere.ChatToolCallsGenerationEventNykiww? value) => new ChatToolCallsGenerationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallsGenerationEvent(
            global::Cohere.ChatStreamEvent? stream,
            global::Cohere.ChatToolCallsGenerationEventNykiww? nykiww
            )
        {
            Stream = stream;
            Nykiww = nykiww;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Nykiww as object ??
            Stream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            Nykiww?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsNykiww;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatStreamEvent, TResult>? stream = null,
            global::System.Func<global::Cohere.ChatToolCallsGenerationEventNykiww, TResult>? nykiww = null,
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
            else if (IsNykiww && nykiww != null)
            {
                return nykiww(Nykiww!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatStreamEvent>? stream = null,

            global::System.Action<global::Cohere.ChatToolCallsGenerationEventNykiww>? nykiww = null,
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
            else if (IsNykiww)
            {
                nykiww?.Invoke(Nykiww!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatStreamEvent>? stream = null,
            global::System.Action<global::Cohere.ChatToolCallsGenerationEventNykiww>? nykiww = null,
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
            else if (IsNykiww)
            {
                nykiww?.Invoke(Nykiww!);
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
                Nykiww,
                typeof(global::Cohere.ChatToolCallsGenerationEventNykiww),
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
        public bool Equals(ChatToolCallsGenerationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEvent?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallsGenerationEventNykiww?>.Default.Equals(Nykiww, other.Nykiww) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolCallsGenerationEvent obj1, ChatToolCallsGenerationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolCallsGenerationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolCallsGenerationEvent obj1, ChatToolCallsGenerationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolCallsGenerationEvent o && Equals(o);
        }
    }
}
