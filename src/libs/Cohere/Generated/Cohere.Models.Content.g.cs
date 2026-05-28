#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A Content block which contains information about the content type and the content itself.
    /// </summary>
    public readonly partial struct Content : global::System.IEquatable<Content>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ContentDiscriminatorType? Type { get; }

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
        public global::Cohere.ChatTextContent PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Image content of the message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ImageContent? ImageUrl { get; init; }
#else
        public global::Cohere.ImageContent? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ImageContent? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ImageContent PickImageUrl() => IsImageUrl
            ? ImageUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content(global::Cohere.ChatTextContent value) => new Content((global::Cohere.ChatTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatTextContent?(Content @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Content(global::Cohere.ChatTextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Content FromText(global::Cohere.ChatTextContent? value) => new Content(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content(global::Cohere.ImageContent value) => new Content((global::Cohere.ImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ImageContent?(Content @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public Content(global::Cohere.ImageContent? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Content FromImageUrl(global::Cohere.ImageContent? value) => new Content(value);

        /// <summary>
        /// 
        /// </summary>
        public Content(
            global::Cohere.ContentDiscriminatorType? type,
            global::Cohere.ChatTextContent? text,
            global::Cohere.ImageContent? imageUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl || !IsText && IsImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatTextContent, TResult>? text = null,
            global::System.Func<global::Cohere.ImageContent, TResult>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatTextContent>? text = null,

            global::System.Action<global::Cohere.ImageContent>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatTextContent>? text = null,
            global::System.Action<global::Cohere.ImageContent>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
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
                ImageUrl,
                typeof(global::Cohere.ImageContent),
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
        public bool Equals(Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatTextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ImageContent?>.Default.Equals(ImageUrl, other.ImageUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Content obj1, Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Content obj1, Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content o && Equals(o);
        }
    }
}
