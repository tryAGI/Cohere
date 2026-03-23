
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The type of citation which indicates what part of the response the citation is for.
    /// </summary>
    public enum CitationType
    {
        /// <summary>
        /// 
        /// </summary>
        Plan,
        /// <summary>
        /// 
        /// </summary>
        TextContent,
        /// <summary>
        /// 
        /// </summary>
        ThinkingContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationType value)
        {
            return value switch
            {
                CitationType.Plan => "PLAN",
                CitationType.TextContent => "TEXT_CONTENT",
                CitationType.ThinkingContent => "THINKING_CONTENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationType? ToEnum(string value)
        {
            return value switch
            {
                "PLAN" => CitationType.Plan,
                "TEXT_CONTENT" => CitationType.TextContent,
                "THINKING_CONTENT" => CitationType.ThinkingContent,
                _ => null,
            };
        }
    }
}