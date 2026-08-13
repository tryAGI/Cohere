
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Block kind.
    /// </summary>
    public enum ParseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Table,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseBlockType value)
        {
            return value switch
            {
                ParseBlockType.Image => "image",
                ParseBlockType.Table => "table",
                ParseBlockType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ParseBlockType.Image,
                "table" => ParseBlockType.Table,
                "text" => ParseBlockType.Text,
                _ => null,
            };
        }
    }
}