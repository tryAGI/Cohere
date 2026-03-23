
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Reasoning is enabled by default for models that support it, but can be turned off by setting `"type": "disabled"`.
    /// </summary>
    public enum ThinkingType
    {
        /// <summary>
        /// "disabled"`.
        /// </summary>
        Disabled,
        /// <summary>
        /// "disabled"`.
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingType value)
        {
            return value switch
            {
                ThinkingType.Disabled => "disabled",
                ThinkingType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ThinkingType.Disabled,
                "enabled" => ThinkingType.Enabled,
                _ => null,
            };
        }
    }
}