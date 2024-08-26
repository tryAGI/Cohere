using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GenerateStreamEnd : global::System.IEquatable<GenerateStreamEnd>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.GenerateStreamEvent? Value1 { get; init; }
#else
        public global::Cohere.GenerateStreamEvent? Value1 { get; }
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
        public static implicit operator GenerateStreamEnd(global::Cohere.GenerateStreamEvent value) => new GenerateStreamEnd(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.GenerateStreamEvent?(GenerateStreamEnd @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamEnd(global::Cohere.GenerateStreamEvent? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.GenerateStreamEndVariant2? Value2 { get; init; }
#else
        public global::Cohere.GenerateStreamEndVariant2? Value2 { get; }
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
        public static implicit operator GenerateStreamEnd(global::Cohere.GenerateStreamEndVariant2 value) => new GenerateStreamEnd(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.GenerateStreamEndVariant2?(GenerateStreamEnd @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamEnd(global::Cohere.GenerateStreamEndVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamEnd(
            global::Cohere.GenerateStreamEvent? value1,
            global::Cohere.GenerateStreamEndVariant2? value2
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
                typeof(global::Cohere.GenerateStreamEvent),
                Value2,
                typeof(global::Cohere.GenerateStreamEndVariant2),
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
        public bool Equals(GenerateStreamEnd other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.GenerateStreamEvent?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.GenerateStreamEndVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateStreamEnd obj1, GenerateStreamEnd obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateStreamEnd>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateStreamEnd obj1, GenerateStreamEnd obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateStreamEnd o && Equals(o);
        }
    }
}
