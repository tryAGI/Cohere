
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantMessageV2Role
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantMessageV2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageV2Role value)
        {
            return value switch
            {
                AssistantMessageV2Role.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageV2Role? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantMessageV2Role.Assistant,
                _ => null,
            };
        }
    }
}