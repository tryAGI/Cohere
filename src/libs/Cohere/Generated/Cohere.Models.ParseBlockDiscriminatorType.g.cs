
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseBlockDiscriminatorType
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
    public static class ParseBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseBlockDiscriminatorType value)
        {
            return value switch
            {
                ParseBlockDiscriminatorType.Image => "image",
                ParseBlockDiscriminatorType.Table => "table",
                ParseBlockDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ParseBlockDiscriminatorType.Image,
                "table" => ParseBlockDiscriminatorType.Table,
                "text" => ParseBlockDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}