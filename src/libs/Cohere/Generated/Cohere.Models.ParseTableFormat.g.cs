
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Serialization format of `content`.
    /// </summary>
    public enum ParseTableFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseTableFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseTableFormat value)
        {
            return value switch
            {
                ParseTableFormat.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseTableFormat? ToEnum(string value)
        {
            return value switch
            {
                "html" => ParseTableFormat.Html,
                _ => null,
            };
        }
    }
}