using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A streamed event which signifies that a stream has started.
    /// </summary>
    public readonly partial struct ChatMessageStartEvent : global::System.IEquatable<ChatMessageStartEvent>
    {
        /// <summary>
        /// The streamed event types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamEventType? Value1 { get; init; }
#else
        public global::Cohere.ChatStreamEventType? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageStartEvent(global::Cohere.ChatStreamEventType value) => new ChatMessageStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEventType?(ChatMessageStartEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageStartEvent(global::Cohere.ChatStreamEventType? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatMessageStartEventVariant2? Value2 { get; init; }
#else
        public global::Cohere.ChatMessageStartEventVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageStartEvent(global::Cohere.ChatMessageStartEventVariant2 value) => new ChatMessageStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessageStartEventVariant2?(ChatMessageStartEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageStartEvent(global::Cohere.ChatMessageStartEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageStartEvent(
            global::Cohere.ChatStreamEventType? value1,
            global::Cohere.ChatMessageStartEventVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Cohere.ChatStreamEventType),
                Value2,
                typeof(global::Cohere.ChatMessageStartEventVariant2),
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
        public bool Equals(ChatMessageStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEventType?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatMessageStartEventVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageStartEvent obj1, ChatMessageStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageStartEvent obj1, ChatMessageStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageStartEvent o && Equals(o);
        }
    }
}
