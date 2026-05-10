#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A streamed event delta which signifies a tool call has started streaming.
    /// </summary>
    public readonly partial struct ChatToolCallStartEvent : global::System.IEquatable<ChatToolCallStartEvent>
    {
        /// <summary>
        /// The streamed event types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamEventType? StreamType { get; init; }
#else
        public global::Cohere.ChatStreamEventType? StreamType { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamType))]
#endif
        public bool IsStreamType => StreamType != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStreamType(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatStreamEventType? value)
        {
            value = StreamType;
            return IsStreamType;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ChatStreamEventType PickStreamType() => IsStreamType
            ? StreamType!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamType' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallStartEventLv559x? Lv559x { get; init; }
#else
        public global::Cohere.ChatToolCallStartEventLv559x? Lv559x { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lv559x))]
#endif
        public bool IsLv559x => Lv559x != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLv559x(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatToolCallStartEventLv559x? value)
        {
            value = Lv559x;
            return IsLv559x;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ChatToolCallStartEventLv559x PickLv559x() => IsLv559x
            ? Lv559x!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Lv559x' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallStartEvent(global::Cohere.ChatStreamEventType value) => new ChatToolCallStartEvent((global::Cohere.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEventType?(ChatToolCallStartEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(global::Cohere.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolCallStartEvent FromStreamType(global::Cohere.ChatStreamEventType? value) => new ChatToolCallStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallStartEvent(global::Cohere.ChatToolCallStartEventLv559x value) => new ChatToolCallStartEvent((global::Cohere.ChatToolCallStartEventLv559x?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallStartEventLv559x?(ChatToolCallStartEvent @this) => @this.Lv559x;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(global::Cohere.ChatToolCallStartEventLv559x? value)
        {
            Lv559x = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolCallStartEvent FromLv559x(global::Cohere.ChatToolCallStartEventLv559x? value) => new ChatToolCallStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(
            global::Cohere.ChatStreamEventType? streamType,
            global::Cohere.ChatToolCallStartEventLv559x? lv559x
            )
        {
            StreamType = streamType;
            Lv559x = lv559x;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Lv559x as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Lv559x?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsLv559x;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatStreamEventType, TResult>? streamType = null,
            global::System.Func<global::Cohere.ChatToolCallStartEventLv559x, TResult>? lv559x = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamType && streamType != null)
            {
                return streamType(StreamType!);
            }
            else if (IsLv559x && lv559x != null)
            {
                return lv559x(Lv559x!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatStreamEventType>? streamType = null,

            global::System.Action<global::Cohere.ChatToolCallStartEventLv559x>? lv559x = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamType)
            {
                streamType?.Invoke(StreamType!);
            }
            else if (IsLv559x)
            {
                lv559x?.Invoke(Lv559x!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatStreamEventType>? streamType = null,
            global::System.Action<global::Cohere.ChatToolCallStartEventLv559x>? lv559x = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamType)
            {
                streamType?.Invoke(StreamType!);
            }
            else if (IsLv559x)
            {
                lv559x?.Invoke(Lv559x!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamType,
                typeof(global::Cohere.ChatStreamEventType),
                Lv559x,
                typeof(global::Cohere.ChatToolCallStartEventLv559x),
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
        public bool Equals(ChatToolCallStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallStartEventLv559x?>.Default.Equals(Lv559x, other.Lv559x) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolCallStartEvent obj1, ChatToolCallStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolCallStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolCallStartEvent obj1, ChatToolCallStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolCallStartEvent o && Equals(o);
        }
    }
}
