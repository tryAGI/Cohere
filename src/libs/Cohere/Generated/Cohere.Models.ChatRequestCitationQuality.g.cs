
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Defaults to `"enabled"`.<br/>
    /// Citations are enabled by default for models that support it, but can be turned off by setting `"type": "disabled"`.<br/>
    /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
    /// </summary>
    public enum ChatRequestCitationQuality
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
    public static class ChatRequestCitationQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCitationQuality value)
        {
            return value switch
            {
                ChatRequestCitationQuality.Accurate => "ACCURATE",
                ChatRequestCitationQuality.Disabled => "DISABLED",
                ChatRequestCitationQuality.Enabled => "ENABLED",
                ChatRequestCitationQuality.Fast => "FAST",
                ChatRequestCitationQuality.Off => "OFF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCitationQuality? ToEnum(string value)
        {
            return value switch
            {
                "ACCURATE" => ChatRequestCitationQuality.Accurate,
                "DISABLED" => ChatRequestCitationQuality.Disabled,
                "ENABLED" => ChatRequestCitationQuality.Enabled,
                "FAST" => ChatRequestCitationQuality.Fast,
                "OFF" => ChatRequestCitationQuality.Off,
                _ => null,
            };
        }
    }
}