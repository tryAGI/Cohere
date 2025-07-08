
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserMessageV2Role
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageV2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageV2Role value)
        {
            return value switch
            {
                UserMessageV2Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageV2Role? ToEnum(string value)
        {
            return value switch
            {
                "user" => UserMessageV2Role.User,
                _ => null,
            };
        }
    }
}