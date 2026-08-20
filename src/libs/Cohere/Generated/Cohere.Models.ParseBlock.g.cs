#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A content block on a parsed page.
    /// </summary>
    public readonly partial struct ParseBlock : global::System.IEquatable<ParseBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ParseBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// A text content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ParseTextContentBlock? Text { get; init; }
#else
        public global::Cohere.ParseTextContentBlock? Text { get; }
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
            out global::Cohere.ParseTextContentBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ParseTextContentBlock PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// An image content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ParseImageContentBlock? Image { get; init; }
#else
        public global::Cohere.ParseImageContentBlock? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ParseImageContentBlock? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ParseImageContentBlock PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// A table content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ParseTableContentBlock? Table { get; init; }
#else
        public global::Cohere.ParseTableContentBlock? Table { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Table))]
#endif
        public bool IsTable => Table != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ParseTableContentBlock? value)
        {
            value = Table;
            return IsTable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ParseTableContentBlock PickTable() => IsTable
            ? Table!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Table' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParseBlock(global::Cohere.ParseTextContentBlock value) => new ParseBlock((global::Cohere.ParseTextContentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ParseTextContentBlock?(ParseBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ParseBlock(global::Cohere.ParseTextContentBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParseBlock FromText(global::Cohere.ParseTextContentBlock? value) => new ParseBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParseBlock(global::Cohere.ParseImageContentBlock value) => new ParseBlock((global::Cohere.ParseImageContentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ParseImageContentBlock?(ParseBlock @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ParseBlock(global::Cohere.ParseImageContentBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParseBlock FromImage(global::Cohere.ParseImageContentBlock? value) => new ParseBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParseBlock(global::Cohere.ParseTableContentBlock value) => new ParseBlock((global::Cohere.ParseTableContentBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ParseTableContentBlock?(ParseBlock @this) => @this.Table;

        /// <summary>
        /// 
        /// </summary>
        public ParseBlock(global::Cohere.ParseTableContentBlock? value)
        {
            Table = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ParseBlock FromTable(global::Cohere.ParseTableContentBlock? value) => new ParseBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public ParseBlock(
            global::Cohere.ParseBlockDiscriminatorType? type,
            global::Cohere.ParseTextContentBlock? text,
            global::Cohere.ParseImageContentBlock? image,
            global::Cohere.ParseTableContentBlock? table
            )
        {
            Type = type;

            Text = text;
            Image = image;
            Table = table;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Table as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            Table?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsTable || !IsText && IsImage && !IsTable || !IsText && !IsImage && IsTable;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ParseTextContentBlock, TResult>? text = null,
            global::System.Func<global::Cohere.ParseImageContentBlock, TResult>? image = null,
            global::System.Func<global::Cohere.ParseTableContentBlock, TResult>? table = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsTable && table != null)
            {
                return table(Table!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ParseTextContentBlock>? text = null,

            global::System.Action<global::Cohere.ParseImageContentBlock>? image = null,

            global::System.Action<global::Cohere.ParseTableContentBlock>? table = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsTable)
            {
                table?.Invoke(Table!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ParseTextContentBlock>? text = null,
            global::System.Action<global::Cohere.ParseImageContentBlock>? image = null,
            global::System.Action<global::Cohere.ParseTableContentBlock>? table = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsTable)
            {
                table?.Invoke(Table!);
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
                typeof(global::Cohere.ParseTextContentBlock),
                Image,
                typeof(global::Cohere.ParseImageContentBlock),
                Table,
                typeof(global::Cohere.ParseTableContentBlock),
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
        public bool Equals(ParseBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ParseTextContentBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ParseImageContentBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ParseTableContentBlock?>.Default.Equals(Table, other.Table) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ParseBlock obj1, ParseBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ParseBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ParseBlock obj1, ParseBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParseBlock o && Equals(o);
        }
    }
}
