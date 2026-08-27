
#nullable enable

namespace Cohere
{
    /// <summary>
    ///
    /// </summary>
    public enum ParseBlocksPageVariantType
    {
        /// <summary>
        ///
        /// </summary>
        Blocks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseBlocksPageVariantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseBlocksPageVariantType value)
        {
            return value switch
            {
                ParseBlocksPageVariantType.Blocks => "blocks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseBlocksPageVariantType? ToEnum(string value)
        {
            return value switch
            {
                "blocks" => ParseBlocksPageVariantType.Blocks,
                _ => null,
            };
        }
    }
}