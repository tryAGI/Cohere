
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum SourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceDiscriminatorType value)
        {
            return value switch
            {
                SourceDiscriminatorType.Tool => "tool",
                SourceDiscriminatorType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => SourceDiscriminatorType.Tool,
                "document" => SourceDiscriminatorType.Document,
                _ => null,
            };
        }
    }
}