
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemMessageV2ContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemMessageV2ContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemMessageV2ContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                SystemMessageV2ContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemMessageV2ContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => SystemMessageV2ContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}