#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A content block which contains information about the content of a tool result
    /// </summary>
    public readonly partial struct ToolContent : global::System.IEquatable<ToolContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ToolContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Text content of the message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatTextContent? Text { get; init; }
#else
        public global::Cohere.ChatTextContent? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatTextContent? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatTextContent PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Document content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.DocumentContent? Document { get; init; }
#else
        public global::Cohere.DocumentContent? Document { get; }
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
            out global::Cohere.DocumentContent? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.DocumentContent PickDocument() => Document is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolContent(global::Cohere.ChatTextContent value) => new ToolContent((global::Cohere.ChatTextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cohere.ChatTextContent?(ToolContent @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ToolContent(global::Cohere.ChatTextContent? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolContent FromText(global::Cohere.ChatTextContent? value) => new ToolContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolContent(global::Cohere.DocumentContent value) => new ToolContent((global::Cohere.DocumentContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cohere.DocumentContent?(ToolContent @this) => @this.Document;

        /// <summary>
        ///
        /// </summary>
        public ToolContent(global::Cohere.DocumentContent? value)
        {
            Document = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolContent FromDocument(global::Cohere.DocumentContent? value) => new ToolContent(value);

        /// <summary>
        ///
        /// </summary>
        public ToolContent(
            global::Cohere.ToolContentDiscriminatorType? type,
            global::Cohere.ChatTextContent? text,
            global::Cohere.DocumentContent? document
            )
        {
            Type = type;

            Text = text;
            Document = document;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Document as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Document?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsDocument || !IsText && IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatTextContent, TResult>? text = null,
            global::System.Func<global::Cohere.DocumentContent, TResult>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Document is { } __value1 && document != null)
            {
                return document(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatTextContent>? text = null,

            global::System.Action<global::Cohere.DocumentContent>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Document is { } __value1)
            {
                document?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatTextContent>? text = null,
            global::System.Action<global::Cohere.DocumentContent>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Document is { } __value1)
            {
                document?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Cohere.ChatTextContent),
                Document,
                typeof(global::Cohere.DocumentContent),
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
        public bool Equals(ToolContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatTextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.DocumentContent?>.Default.Equals(Document, other.Document)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolContent obj1, ToolContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolContent obj1, ToolContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolContent o && Equals(o);
        }
    }
}
