
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantMessageContentVariant2ItemDiscriminatorType
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
    public static class AssistantMessageContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                AssistantMessageContentVariant2ItemDiscriminatorType.Text => "text",
                AssistantMessageContentVariant2ItemDiscriminatorType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AssistantMessageContentVariant2ItemDiscriminatorType.Text,
                "thinking" => AssistantMessageContentVariant2ItemDiscriminatorType.Thinking,
                _ => null,
            };
        }
    }
}