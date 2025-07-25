
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatContentStartEventVariant2DeltaMessageContentType
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
    public static class ChatContentStartEventVariant2DeltaMessageContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentStartEventVariant2DeltaMessageContentType value)
        {
            return value switch
            {
                ChatContentStartEventVariant2DeltaMessageContentType.Text => "text",
                ChatContentStartEventVariant2DeltaMessageContentType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentStartEventVariant2DeltaMessageContentType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatContentStartEventVariant2DeltaMessageContentType.Text,
                "thinking" => ChatContentStartEventVariant2DeltaMessageContentType.Thinking,
                _ => null,
            };
        }
    }
}