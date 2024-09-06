using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A source object containing information about the source of the data cited.
    /// </summary>
    public readonly partial struct Source : global::System.IEquatable<Source>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ToolSource? Tool { get; init; }
#else
        public global::Cohere.ToolSource? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Cohere.ToolSource value) => new Source(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ToolSource?(Source @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Cohere.ToolSource? value)
        {
            Tool = value;
        }

        /// <summary>
        /// A document source object containing the unique identifier of the document and the document itself.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.DocumentSource? Document { get; init; }
#else
        public global::Cohere.DocumentSource? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Cohere.DocumentSource value) => new Source(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.DocumentSource?(Source @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Cohere.DocumentSource? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::Cohere.ToolSource? tool,
            global::Cohere.DocumentSource? document
            )
        {
            Tool = tool;
            Document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Document as object ??
            Tool as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTool && !IsDocument || !IsTool && IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Tool,
                typeof(global::Cohere.ToolSource),
                Document,
                typeof(global::Cohere.DocumentSource),
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
        public bool Equals(Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ToolSource?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.DocumentSource?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source obj1, Source obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source obj1, Source obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source o && Equals(o);
        }
    }
}
