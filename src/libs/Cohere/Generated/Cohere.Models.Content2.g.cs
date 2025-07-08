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
        public static implicit operator Content2(global::Cohere.ChatTextContent value) => new Content2((global::Cohere.ChatTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatTextContent?(Content2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Content2(global::Cohere.ChatTextContent? value)
        {
            Text = value;
        }

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
        public static implicit operator Content2(global::Cohere.ImageContent value) => new Content2((global::Cohere.ImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ImageContent?(Content2 @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public Content2(global::Cohere.ImageContent? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Content2(
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
            global::System.Func<global::Cohere.ChatTextContent?, TResult>? text = null,
            global::System.Func<global::Cohere.ImageContent?, TResult>? imageUrl = null,
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
            global::System.Action<global::Cohere.ChatTextContent?>? text = null,
            global::System.Action<global::Cohere.ImageContent?>? imageUrl = null,
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
        public bool Equals(Content2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatTextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ImageContent?>.Default.Equals(ImageUrl, other.ImageUrl) 
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
