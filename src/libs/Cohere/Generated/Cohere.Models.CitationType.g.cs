
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
        TextContent,
        /// <summary>
        /// 
        /// </summary>
        ThinkingContent,
        /// <summary>
        /// 
        /// </summary>
        Plan,
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
                CitationType.TextContent => "TEXT_CONTENT",
                CitationType.ThinkingContent => "THINKING_CONTENT",
                CitationType.Plan => "PLAN",
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
                "TEXT_CONTENT" => CitationType.TextContent,
                "THINKING_CONTENT" => CitationType.ThinkingContent,
                "PLAN" => CitationType.Plan,
                _ => null,
            };
        }
    }
}