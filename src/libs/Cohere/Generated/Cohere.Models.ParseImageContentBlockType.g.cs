
#nullable enable

namespace Cohere
{
    /// <summary>
    ///
    /// </summary>
    public enum ParseImageContentBlockType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseImageContentBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseImageContentBlockType value)
        {
            return value switch
            {
                ParseImageContentBlockType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseImageContentBlockType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ParseImageContentBlockType.Image,
                _ => null,
            };
        }
    }
}