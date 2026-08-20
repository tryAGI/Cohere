
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseMarkdownPageVariantType
    {
        /// <summary>
        /// 
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseMarkdownPageVariantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseMarkdownPageVariantType value)
        {
            return value switch
            {
                ParseMarkdownPageVariantType.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseMarkdownPageVariantType? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => ParseMarkdownPageVariantType.Markdown,
                _ => null,
            };
        }
    }
}