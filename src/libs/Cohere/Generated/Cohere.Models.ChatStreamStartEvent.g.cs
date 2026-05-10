#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatStreamStartEvent : global::System.IEquatable<ChatStreamStartEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamEvent? ChatStreamEvent { get; init; }
#else
        public global::Cohere.ChatStreamEvent? ChatStreamEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatStreamEvent))]
#endif
        public bool IsChatStreamEvent => ChatStreamEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatStreamEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatStreamEvent? value)
        {
            value = ChatStreamEvent;
            return IsChatStreamEvent;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamStartEvent5v9jyv? Event5v9jyv { get; init; }
#else
        public global::Cohere.ChatStreamStartEvent5v9jyv? Event5v9jyv { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event5v9jyv))]
#endif
        public bool IsEvent5v9jyv => Event5v9jyv != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEvent5v9jyv(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatStreamStartEvent5v9jyv? value)
        {
            value = Event5v9jyv;
            return IsEvent5v9jyv;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamStartEvent(global::Cohere.ChatStreamEvent value) => new ChatStreamStartEvent((global::Cohere.ChatStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEvent?(ChatStreamStartEvent @this) => @this.ChatStreamEvent;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamStartEvent(global::Cohere.ChatStreamEvent? value)
        {
            ChatStreamEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatStreamStartEvent FromChatStreamEvent(global::Cohere.ChatStreamEvent? value) => new ChatStreamStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatStreamStartEvent(global::Cohere.ChatStreamStartEvent5v9jyv value) => new ChatStreamStartEvent((global::Cohere.ChatStreamStartEvent5v9jyv?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamStartEvent5v9jyv?(ChatStreamStartEvent @this) => @this.Event5v9jyv;

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamStartEvent(global::Cohere.ChatStreamStartEvent5v9jyv? value)
        {
            Event5v9jyv = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatStreamStartEvent FromEvent5v9jyv(global::Cohere.ChatStreamStartEvent5v9jyv? value) => new ChatStreamStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatStreamStartEvent(
            global::Cohere.ChatStreamEvent? chatStreamEvent,
            global::Cohere.ChatStreamStartEvent5v9jyv? event5v9jyv
            )
        {
            ChatStreamEvent = chatStreamEvent;
            Event5v9jyv = event5v9jyv;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event5v9jyv as object ??
            ChatStreamEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatStreamEvent?.ToString() ??
            Event5v9jyv?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatStreamEvent && IsEvent5v9jyv;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatStreamEvent, TResult>? chatStreamEvent = null,
            global::System.Func<global::Cohere.ChatStreamStartEvent5v9jyv, TResult>? event5v9jyv = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamEvent && chatStreamEvent != null)
            {
                return chatStreamEvent(ChatStreamEvent!);
            }
            else if (IsEvent5v9jyv && event5v9jyv != null)
            {
                return event5v9jyv(Event5v9jyv!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatStreamEvent>? chatStreamEvent = null,

            global::System.Action<global::Cohere.ChatStreamStartEvent5v9jyv>? event5v9jyv = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamEvent)
            {
                chatStreamEvent?.Invoke(ChatStreamEvent!);
            }
            else if (IsEvent5v9jyv)
            {
                event5v9jyv?.Invoke(Event5v9jyv!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatStreamEvent>? chatStreamEvent = null,
            global::System.Action<global::Cohere.ChatStreamStartEvent5v9jyv>? event5v9jyv = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamEvent)
            {
                chatStreamEvent?.Invoke(ChatStreamEvent!);
            }
            else if (IsEvent5v9jyv)
            {
                event5v9jyv?.Invoke(Event5v9jyv!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatStreamEvent,
                typeof(global::Cohere.ChatStreamEvent),
                Event5v9jyv,
                typeof(global::Cohere.ChatStreamStartEvent5v9jyv),
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
        public bool Equals(ChatStreamStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEvent?>.Default.Equals(ChatStreamEvent, other.ChatStreamEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamStartEvent5v9jyv?>.Default.Equals(Event5v9jyv, other.Event5v9jyv) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatStreamStartEvent obj1, ChatStreamStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatStreamStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatStreamStartEvent obj1, ChatStreamStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatStreamStartEvent o && Equals(o);
        }
    }
}
