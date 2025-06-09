
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemMessageV2Role
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemMessageV2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemMessageV2Role value)
        {
            return value switch
            {
                SystemMessageV2Role.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemMessageV2Role? ToEnum(string value)
        {
            return value switch
            {
                "system" => SystemMessageV2Role.System,
                _ => null,
            };
        }
    }
}