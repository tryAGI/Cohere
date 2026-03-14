
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public enum TruncationStrategyDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TruncationStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TruncationStrategyDiscriminatorType value)
        {
            return value switch
            {
                TruncationStrategyDiscriminatorType.Auto => "auto",
                TruncationStrategyDiscriminatorType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TruncationStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TruncationStrategyDiscriminatorType.Auto,
                "none" => TruncationStrategyDiscriminatorType.None,
                _ => null,
            };
        }
    }
}