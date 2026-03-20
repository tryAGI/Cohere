
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatContentStartEventDeltaMessageContentType
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
    public static class ChatContentStartEventDeltaMessageContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentStartEventDeltaMessageContentType value)
        {
            return value switch
            {
                ChatContentStartEventDeltaMessageContentType.Text => "text",
                ChatContentStartEventDeltaMessageContentType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentStartEventDeltaMessageContentType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatContentStartEventDeltaMessageContentType.Text,
                "thinking" => ChatContentStartEventDeltaMessageContentType.Thinking,
                _ => null,
            };
        }
    }
}