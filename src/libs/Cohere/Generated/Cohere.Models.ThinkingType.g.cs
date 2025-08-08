
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThinkingType
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
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
                ThinkingType.Enabled => "enabled",
                ThinkingType.Disabled => "disabled",
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
                "enabled" => ThinkingType.Enabled,
                "disabled" => ThinkingType.Disabled,
                _ => null,
            };
        }
    }
}