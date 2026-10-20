
#nullable enable

namespace Cohere
{
    /// <summary>
    /// One of `"enabled"` or `"disabled"`. Controls whether relevant spans will be returned in the API response.
    /// </summary>
    public enum RerankRelevantSpansMode
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerankRelevantSpansModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerankRelevantSpansMode value)
        {
            return value switch
            {
                RerankRelevantSpansMode.Disabled => "disabled",
                RerankRelevantSpansMode.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerankRelevantSpansMode? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => RerankRelevantSpansMode.Disabled,
                "enabled" => RerankRelevantSpansMode.Enabled,
                _ => null,
            };
        }
    }
}