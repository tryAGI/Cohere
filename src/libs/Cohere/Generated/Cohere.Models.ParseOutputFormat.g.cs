
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Selects the page payload shape in the response. Defaults to `"markdown"`.<br/>
    /// - `"markdown"`: each page includes markdown content. Tables are inlined as<br/>
    ///   HTML, and images are referenced as `![&lt;description&gt;](&lt;image_id&gt;)` with<br/>
    ///   matching entries in `page.markdown.images`.<br/>
    /// - `"blocks"`: each page includes an ordered `blocks` array of text, image,<br/>
    ///   and table content regions, including bounding boxes where available.<br/>
    /// Default Value: markdown
    /// </summary>
    public enum ParseOutputFormat
    {
        /// <summary>
        /// each page includes an ordered `blocks` array of text, image,
        /// </summary>
        Blocks,
        /// <summary>
        /// each page includes markdown content. Tables are inlined as
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseOutputFormat value)
        {
            return value switch
            {
                ParseOutputFormat.Blocks => "blocks",
                ParseOutputFormat.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "blocks" => ParseOutputFormat.Blocks,
                "markdown" => ParseOutputFormat.Markdown,
                _ => null,
            };
        }
    }
}