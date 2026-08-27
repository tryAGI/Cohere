
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Table serialization format.
    /// </summary>
    public enum ParseTableContentType
    {
        /// <summary>
        ///
        /// </summary>
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseTableContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseTableContentType value)
        {
            return value switch
            {
                ParseTableContentType.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseTableContentType? ToEnum(string value)
        {
            return value switch
            {
                "html" => ParseTableContentType.Html,
                _ => null,
            };
        }
    }
}