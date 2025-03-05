
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolContentDiscriminatorType value)
        {
            return value switch
            {
                ToolContentDiscriminatorType.Document => "document",
                ToolContentDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document" => ToolContentDiscriminatorType.Document,
                "text" => ToolContentDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}