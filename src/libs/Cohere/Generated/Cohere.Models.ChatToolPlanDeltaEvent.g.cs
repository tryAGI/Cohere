#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A streamed event which contains a delta of tool plan text.
    /// </summary>
    public readonly partial struct ChatToolPlanDeltaEvent : global::System.IEquatable<ChatToolPlanDeltaEvent>
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
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolPlanDeltaEvent2obfex? Event2obfex { get; init; }
#else
        public global::Cohere.ChatToolPlanDeltaEvent2obfex? Event2obfex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event2obfex))]
#endif
        public bool IsEvent2obfex => Event2obfex != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEvent2obfex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatToolPlanDeltaEvent2obfex? value)
        {
            value = Event2obfex;
            return IsEvent2obfex;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolPlanDeltaEvent(global::Cohere.ChatStreamEventType value) => new ChatToolPlanDeltaEvent((global::Cohere.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEventType?(ChatToolPlanDeltaEvent @this) => @this.StreamType;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolPlanDeltaEvent(global::Cohere.ChatStreamEventType? value)
        {
            StreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolPlanDeltaEvent FromStreamType(global::Cohere.ChatStreamEventType? value) => new ChatToolPlanDeltaEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolPlanDeltaEvent(global::Cohere.ChatToolPlanDeltaEvent2obfex value) => new ChatToolPlanDeltaEvent((global::Cohere.ChatToolPlanDeltaEvent2obfex?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolPlanDeltaEvent2obfex?(ChatToolPlanDeltaEvent @this) => @this.Event2obfex;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolPlanDeltaEvent(global::Cohere.ChatToolPlanDeltaEvent2obfex? value)
        {
            Event2obfex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolPlanDeltaEvent FromEvent2obfex(global::Cohere.ChatToolPlanDeltaEvent2obfex? value) => new ChatToolPlanDeltaEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatToolPlanDeltaEvent(
            global::Cohere.ChatStreamEventType? streamType,
            global::Cohere.ChatToolPlanDeltaEvent2obfex? event2obfex
            )
        {
            StreamType = streamType;
            Event2obfex = event2obfex;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Event2obfex as object ??
            StreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamType?.ToString() ??
            Event2obfex?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamType && IsEvent2obfex;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatStreamEventType, TResult>? streamType = null,
            global::System.Func<global::Cohere.ChatToolPlanDeltaEvent2obfex, TResult>? event2obfex = null,
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
            else if (IsEvent2obfex && event2obfex != null)
            {
                return event2obfex(Event2obfex!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatStreamEventType>? streamType = null,

            global::System.Action<global::Cohere.ChatToolPlanDeltaEvent2obfex>? event2obfex = null,
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
            else if (IsEvent2obfex)
            {
                event2obfex?.Invoke(Event2obfex!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatStreamEventType>? streamType = null,
            global::System.Action<global::Cohere.ChatToolPlanDeltaEvent2obfex>? event2obfex = null,
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
            else if (IsEvent2obfex)
            {
                event2obfex?.Invoke(Event2obfex!);
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
                Event2obfex,
                typeof(global::Cohere.ChatToolPlanDeltaEvent2obfex),
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
        public bool Equals(ChatToolPlanDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEventType?>.Default.Equals(StreamType, other.StreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolPlanDeltaEvent2obfex?>.Default.Equals(Event2obfex, other.Event2obfex) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolPlanDeltaEvent obj1, ChatToolPlanDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolPlanDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolPlanDeltaEvent obj1, ChatToolPlanDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolPlanDeltaEvent o && Equals(o);
        }
    }
}
