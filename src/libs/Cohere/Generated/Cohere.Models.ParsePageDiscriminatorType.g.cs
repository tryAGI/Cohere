
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParsePageDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Blocks,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParsePageDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParsePageDiscriminatorType value)
        {
            return value switch
            {
                ParsePageDiscriminatorType.Blocks => "blocks",
                ParsePageDiscriminatorType.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParsePageDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "blocks" => ParsePageDiscriminatorType.Blocks,
                "markdown" => ParsePageDiscriminatorType.Markdown,
                _ => null,
            };
        }
    }
}