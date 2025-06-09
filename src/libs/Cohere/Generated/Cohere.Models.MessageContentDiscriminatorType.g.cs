
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentDiscriminatorType value)
        {
            return value switch
            {
                MessageContentDiscriminatorType.ImageUrl => "image_url",
                MessageContentDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MessageContentDiscriminatorType.ImageUrl,
                "text" => MessageContentDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}