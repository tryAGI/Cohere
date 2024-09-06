using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A streamed event which signifies a citation has been created.
    /// </summary>
    public readonly partial struct CitationStartEvent : global::System.IEquatable<CitationStartEvent>
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
        public static implicit operator CitationStartEvent(global::Cohere.ChatStreamEventType value) => new CitationStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEventType?(CitationStartEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public CitationStartEvent(global::Cohere.ChatStreamEventType? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.CitationStartEventVariant2? Value2 { get; init; }
#else
        public global::Cohere.CitationStartEventVariant2? Value2 { get; }
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
        public static implicit operator CitationStartEvent(global::Cohere.CitationStartEventVariant2 value) => new CitationStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.CitationStartEventVariant2?(CitationStartEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public CitationStartEvent(global::Cohere.CitationStartEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationStartEvent(
            global::Cohere.ChatStreamEventType? value1,
            global::Cohere.CitationStartEventVariant2? value2
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
                typeof(global::Cohere.CitationStartEventVariant2),
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
        public bool Equals(CitationStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEventType?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.CitationStartEventVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationStartEvent obj1, CitationStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationStartEvent obj1, CitationStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationStartEvent o && Equals(o);
        }
    }
}
