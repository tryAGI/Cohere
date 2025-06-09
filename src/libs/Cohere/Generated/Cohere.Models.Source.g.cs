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
        public global::Cohere.ChatToolSource? ChatTool { get; init; }
#else
        public global::Cohere.ChatToolSource? ChatTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatTool))]
#endif
        public bool IsChatTool => ChatTool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Cohere.ChatToolSource value) => new Source((global::Cohere.ChatToolSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolSource?(Source @this) => @this.ChatTool;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Cohere.ChatToolSource? value)
        {
            ChatTool = value;
        }

        /// <summary>
        /// A document source object containing the unique identifier of the document and the document itself.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatDocumentSource? ChatDocument { get; init; }
#else
        public global::Cohere.ChatDocumentSource? ChatDocument { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatDocument))]
#endif
        public bool IsChatDocument => ChatDocument != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::Cohere.ChatDocumentSource value) => new Source((global::Cohere.ChatDocumentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatDocumentSource?(Source @this) => @this.ChatDocument;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::Cohere.ChatDocumentSource? value)
        {
            ChatDocument = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::Cohere.ChatToolSource? chatTool,
            global::Cohere.ChatDocumentSource? chatDocument
            )
        {
            ChatTool = chatTool;
            ChatDocument = chatDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatDocument as object ??
            ChatTool as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatTool?.ToString() ??
            ChatDocument?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatTool && !IsChatDocument || !IsChatTool && IsChatDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatToolSource?, TResult>? chatTool = null,
            global::System.Func<global::Cohere.ChatDocumentSource?, TResult>? chatDocument = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatTool && chatTool != null)
            {
                return chatTool(ChatTool!);
            }
            else if (IsChatDocument && chatDocument != null)
            {
                return chatDocument(ChatDocument!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatToolSource?>? chatTool = null,
            global::System.Action<global::Cohere.ChatDocumentSource?>? chatDocument = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatTool)
            {
                chatTool?.Invoke(ChatTool!);
            }
            else if (IsChatDocument)
            {
                chatDocument?.Invoke(ChatDocument!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatTool,
                typeof(global::Cohere.ChatToolSource),
                ChatDocument,
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
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolSource?>.Default.Equals(ChatTool, other.ChatTool) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatDocumentSource?>.Default.Equals(ChatDocument, other.ChatDocument) 
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
