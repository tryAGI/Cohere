
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantMessageV2ContentOneItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageV2ContentOneItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageV2ContentOneItemDiscriminatorType value)
        {
            return value switch
            {
                AssistantMessageV2ContentOneItemDiscriminatorType.Text => "text",
                AssistantMessageV2ContentOneItemDiscriminatorType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageV2ContentOneItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AssistantMessageV2ContentOneItemDiscriminatorType.Text,
                "thinking" => AssistantMessageV2ContentOneItemDiscriminatorType.Thinking,
                _ => null,
            };
        }
    }
}