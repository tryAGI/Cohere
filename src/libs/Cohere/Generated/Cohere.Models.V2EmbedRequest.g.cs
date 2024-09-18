using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2EmbedRequest : global::System.IEquatable<V2EmbedRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.Texts? Texts { get; init; }
#else
        public global::Cohere.Texts? Texts { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Texts))]
#endif
        public bool IsTexts => Texts != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2EmbedRequest(global::Cohere.Texts value) => new V2EmbedRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.Texts?(V2EmbedRequest @this) => @this.Texts;

        /// <summary>
        /// 
        /// </summary>
        public V2EmbedRequest(global::Cohere.Texts? value)
        {
            Texts = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.Images? Images { get; init; }
#else
        public global::Cohere.Images? Images { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Images))]
#endif
        public bool IsImages => Images != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2EmbedRequest(global::Cohere.Images value) => new V2EmbedRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.Images?(V2EmbedRequest @this) => @this.Images;

        /// <summary>
        /// 
        /// </summary>
        public V2EmbedRequest(global::Cohere.Images? value)
        {
            Images = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V2EmbedRequest(
            global::Cohere.Texts? texts,
            global::Cohere.Images? images
            )
        {
            Texts = texts;
            Images = images;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Images as object ??
            Texts as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTexts && !IsImages || !IsTexts && IsImages;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Texts,
                typeof(global::Cohere.Texts),
                Images,
                typeof(global::Cohere.Images),
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
        public bool Equals(V2EmbedRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.Texts?>.Default.Equals(Texts, other.Texts) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.Images?>.Default.Equals(Images, other.Images) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2EmbedRequest obj1, V2EmbedRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2EmbedRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2EmbedRequest obj1, V2EmbedRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2EmbedRequest o && Equals(o);
        }
    }
}
