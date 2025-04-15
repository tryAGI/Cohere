#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbedContent : global::System.IEquatable<EmbedContent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.EmbedContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Image content of the input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.EmbedImage? ImageUrl { get; init; }
#else
        public global::Cohere.EmbedImage? ImageUrl { get; }
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
        public static implicit operator EmbedContent(global::Cohere.EmbedImage value) => new EmbedContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.EmbedImage?(EmbedContent @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public EmbedContent(global::Cohere.EmbedImage? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// Text content of the input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.EmbedText? Text { get; init; }
#else
        public global::Cohere.EmbedText? Text { get; }
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
        public static implicit operator EmbedContent(global::Cohere.EmbedText value) => new EmbedContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.EmbedText?(EmbedContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public EmbedContent(global::Cohere.EmbedText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbedContent(
            global::Cohere.EmbedContentDiscriminatorType? type,
            global::Cohere.EmbedImage? imageUrl,
            global::Cohere.EmbedText? text
            )
        {
            Type = type;

            ImageUrl = imageUrl;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            ImageUrl as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageUrl?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageUrl && !IsText || !IsImageUrl && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.EmbedImage?, TResult>? imageUrl = null,
            global::System.Func<global::Cohere.EmbedText?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.EmbedImage?>? imageUrl = null,
            global::System.Action<global::Cohere.EmbedText?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageUrl,
                typeof(global::Cohere.EmbedImage),
                Text,
                typeof(global::Cohere.EmbedText),
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
        public bool Equals(EmbedContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.EmbedImage?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.EmbedText?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbedContent obj1, EmbedContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbedContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbedContent obj1, EmbedContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbedContent o && Equals(o);
        }
    }
}
