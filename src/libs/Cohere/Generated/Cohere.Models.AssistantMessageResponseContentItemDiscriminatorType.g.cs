
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantMessageResponseContentItemDiscriminatorType
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
    public static class AssistantMessageResponseContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageResponseContentItemDiscriminatorType value)
        {
            return value switch
            {
                AssistantMessageResponseContentItemDiscriminatorType.Text => "text",
                AssistantMessageResponseContentItemDiscriminatorType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageResponseContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AssistantMessageResponseContentItemDiscriminatorType.Text,
                "thinking" => AssistantMessageResponseContentItemDiscriminatorType.Thinking,
                _ => null,
            };
        }
    }
}