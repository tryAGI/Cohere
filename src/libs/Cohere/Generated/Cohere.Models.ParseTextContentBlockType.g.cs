
#nullable enable

namespace Cohere
{
    /// <summary>
    ///
    /// </summary>
    public enum ParseTextContentBlockType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseTextContentBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseTextContentBlockType value)
        {
            return value switch
            {
                ParseTextContentBlockType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseTextContentBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ParseTextContentBlockType.Text,
                _ => null,
            };
        }
    }
}