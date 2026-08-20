
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseTableContentBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseTableContentBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseTableContentBlockType value)
        {
            return value switch
            {
                ParseTableContentBlockType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseTableContentBlockType? ToEnum(string value)
        {
            return value switch
            {
                "table" => ParseTableContentBlockType.Table,
                _ => null,
            };
        }
    }
}