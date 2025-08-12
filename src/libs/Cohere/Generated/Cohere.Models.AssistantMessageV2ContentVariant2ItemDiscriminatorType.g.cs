
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantMessageV2ContentVariant2ItemDiscriminatorType
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
    public static class AssistantMessageV2ContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageV2ContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                AssistantMessageV2ContentVariant2ItemDiscriminatorType.Text => "text",
                AssistantMessageV2ContentVariant2ItemDiscriminatorType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageV2ContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AssistantMessageV2ContentVariant2ItemDiscriminatorType.Text,
                "thinking" => AssistantMessageV2ContentVariant2ItemDiscriminatorType.Thinking,
                _ => null,
            };
        }
    }
}