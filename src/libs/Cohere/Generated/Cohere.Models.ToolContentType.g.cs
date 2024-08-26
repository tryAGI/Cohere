
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResultObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolContentType value)
        {
            return value switch
            {
                ToolContentType.ToolResultObject => "tool_result_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolContentType? ToEnum(string value)
        {
            return value switch
            {
                "tool_result_object" => ToolContentType.ToolResultObject,
                _ => null,
            };
        }
    }
}