
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Defaults to `"enabled"`.<br/>
    /// Citations are enabled by default for models that support it, but can be turned off by setting `"type": "disabled"`.
    /// </summary>
    public enum CitationOptionsMode
    {
        /// <summary>
        /// 
        /// </summary>
        Accurate,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationOptionsMode value)
        {
            return value switch
            {
                CitationOptionsMode.Accurate => "ACCURATE",
                CitationOptionsMode.Disabled => "DISABLED",
                CitationOptionsMode.Enabled => "ENABLED",
                CitationOptionsMode.Fast => "FAST",
                CitationOptionsMode.Off => "OFF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "ACCURATE" => CitationOptionsMode.Accurate,
                "DISABLED" => CitationOptionsMode.Disabled,
                "ENABLED" => CitationOptionsMode.Enabled,
                "FAST" => CitationOptionsMode.Fast,
                "OFF" => CitationOptionsMode.Off,
                _ => null,
            };
        }
    }
}