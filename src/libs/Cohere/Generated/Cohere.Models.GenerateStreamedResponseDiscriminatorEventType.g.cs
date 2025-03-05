
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateStreamedResponseDiscriminatorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        StreamEnd,
        /// <summary>
        /// 
        /// </summary>
        StreamError,
        /// <summary>
        /// 
        /// </summary>
        TextGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateStreamedResponseDiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateStreamedResponseDiscriminatorEventType value)
        {
            return value switch
            {
                GenerateStreamedResponseDiscriminatorEventType.StreamEnd => "stream-end",
                GenerateStreamedResponseDiscriminatorEventType.StreamError => "stream-error",
                GenerateStreamedResponseDiscriminatorEventType.TextGeneration => "text-generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateStreamedResponseDiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "stream-end" => GenerateStreamedResponseDiscriminatorEventType.StreamEnd,
                "stream-error" => GenerateStreamedResponseDiscriminatorEventType.StreamError,
                "text-generation" => GenerateStreamedResponseDiscriminatorEventType.TextGeneration,
                _ => null,
            };
        }
    }
}