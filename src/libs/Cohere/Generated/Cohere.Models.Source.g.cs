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
        public global::Cohere.SourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolSource? Tool { get; init; }
#else
        public global::Cohere.ChatToolSource? Tool { get; }
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
        public bool TryPickTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatToolSource? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        /// A document source object containing the unique identifier of the document and the document itself.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatDocumentSource? Document { get; init; }
#else
        public global::Cohere.ChatDocumentSource? Document { get; }
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
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatDocumentSource? value)
        {
            value = Document;
            return IsDocument;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Cohere.ChatToolSource value) => new Source((global::Cohere.ChatToolSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolSource?(Source @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Cohere.ChatToolSource? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Cohere.ChatDocumentSource value) => new Source((global::Cohere.ChatDocumentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatDocumentSource?(Source @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Cohere.ChatDocumentSource? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::Cohere.SourceDiscriminatorType? type,
            global::Cohere.ChatToolSource? tool,
            global::Cohere.ChatDocumentSource? document
            )
        {
            Type = type;

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
        public override string? ToString() =>
            Tool?.ToString() ??
            Document?.ToString() 
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
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatToolSource, TResult>? tool = null,
            global::System.Func<global::Cohere.ChatDocumentSource, TResult>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatToolSource>? tool = null,

            global::System.Action<global::Cohere.ChatDocumentSource>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatToolSource>? tool = null,
            global::System.Action<global::Cohere.ChatDocumentSource>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Tool,
                typeof(global::Cohere.ChatToolSource),
                Document,
                typeof(global::Cohere.ChatDocumentSource),
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
        public bool Equals(Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolSource?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatDocumentSource?>.Default.Equals(Document, other.Document) 
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
