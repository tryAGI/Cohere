#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A single parsed page. The payload shape depends on `output_format`.
    /// </summary>
    public readonly partial struct ParsePage : global::System.IEquatable<ParsePage>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParsePageDiscriminatorType? Type { get; }

        /// <summary>
        /// A parsed page with structured content blocks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ParseBlocksPageVariant? Blocks { get; init; }
#else
        public global::Cohere.ParseBlocksPageVariant? Blocks { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Blocks))]
#endif
        public bool IsBlocks => Blocks != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlocks(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ParseBlocksPageVariant? value)
        {
            value = Blocks;
            return IsBlocks;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseBlocksPageVariant PickBlocks() => IsBlocks
            ? Blocks!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Blocks' but the value was {ToString()}.");

        /// <summary>
        /// A parsed page with markdown content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ParseMarkdownPageVariant? Markdown { get; init; }
#else
        public global::Cohere.ParseMarkdownPageVariant? Markdown { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Markdown))]
#endif
        public bool IsMarkdown => Markdown != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMarkdown(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ParseMarkdownPageVariant? value)
        {
            value = Markdown;
            return IsMarkdown;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ParseMarkdownPageVariant PickMarkdown() => IsMarkdown
            ? Markdown!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Markdown' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParsePage(global::Cohere.ParseBlocksPageVariant value) => new ParsePage((global::Cohere.ParseBlocksPageVariant?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cohere.ParseBlocksPageVariant?(ParsePage @this) => @this.Blocks;

        /// <summary>
        ///
        /// </summary>
        public ParsePage(global::Cohere.ParseBlocksPageVariant? value)
        {
            Blocks = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParsePage FromBlocks(global::Cohere.ParseBlocksPageVariant? value) => new ParsePage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ParsePage(global::Cohere.ParseMarkdownPageVariant value) => new ParsePage((global::Cohere.ParseMarkdownPageVariant?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cohere.ParseMarkdownPageVariant?(ParsePage @this) => @this.Markdown;

        /// <summary>
        ///
        /// </summary>
        public ParsePage(global::Cohere.ParseMarkdownPageVariant? value)
        {
            Markdown = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ParsePage FromMarkdown(global::Cohere.ParseMarkdownPageVariant? value) => new ParsePage(value);

        /// <summary>
        ///
        /// </summary>
        public ParsePage(
            global::Cohere.ParsePageDiscriminatorType? type,
            global::Cohere.ParseBlocksPageVariant? blocks,
            global::Cohere.ParseMarkdownPageVariant? markdown
            )
        {
            Type = type;

            Blocks = blocks;
            Markdown = markdown;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Markdown as object ??
            Blocks as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Blocks?.ToString() ??
            Markdown?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBlocks && !IsMarkdown || !IsBlocks && IsMarkdown;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ParseBlocksPageVariant, TResult>? blocks = null,
            global::System.Func<global::Cohere.ParseMarkdownPageVariant, TResult>? markdown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBlocks && blocks != null)
            {
                return blocks(Blocks!);
            }
            else if (IsMarkdown && markdown != null)
            {
                return markdown(Markdown!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ParseBlocksPageVariant>? blocks = null,

            global::System.Action<global::Cohere.ParseMarkdownPageVariant>? markdown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBlocks)
            {
                blocks?.Invoke(Blocks!);
            }
            else if (IsMarkdown)
            {
                markdown?.Invoke(Markdown!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ParseBlocksPageVariant>? blocks = null,
            global::System.Action<global::Cohere.ParseMarkdownPageVariant>? markdown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBlocks)
            {
                blocks?.Invoke(Blocks!);
            }
            else if (IsMarkdown)
            {
                markdown?.Invoke(Markdown!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Blocks,
                typeof(global::Cohere.ParseBlocksPageVariant),
                Markdown,
                typeof(global::Cohere.ParseMarkdownPageVariant),
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
        public bool Equals(ParsePage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ParseBlocksPageVariant?>.Default.Equals(Blocks, other.Blocks) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ParseMarkdownPageVariant?>.Default.Equals(Markdown, other.Markdown)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ParsePage obj1, ParsePage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ParsePage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ParsePage obj1, ParsePage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParsePage o && Equals(o);
        }
    }
}
