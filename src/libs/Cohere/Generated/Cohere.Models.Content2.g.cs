using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A Content block which contains information about the content type and the content itself.
    /// </summary>
    public readonly partial struct Content2 : global::System.IEquatable<Content2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.TextContent? TextContent { get; init; }
#else
        public global::Cohere.TextContent? TextContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextContent))]
#endif
        public bool IsTextContent => TextContent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content2(global::Cohere.TextContent value) => new Content2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.TextContent?(Content2 @this) => @this.TextContent;

        /// <summary>
        /// 
        /// </summary>
        public Content2(global::Cohere.TextContent? value)
        {
            TextContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextContent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextContent,
                typeof(global::Cohere.TextContent),
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
        public bool Equals(Content2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.TextContent?>.Default.Equals(TextContent, other.TextContent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Content2 obj1, Content2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Content2 obj1, Content2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content2 o && Equals(o);
        }
    }
}
