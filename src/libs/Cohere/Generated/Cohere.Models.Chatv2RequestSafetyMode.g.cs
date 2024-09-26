
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Used to select the [safety instruction](https://docs.cohere.com/v2/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
    /// When `OFF` is specified, the safety instruction will be omitted.<br/>
    /// Safety modes are not yet configurable in combination with `tools`, `tool_results` and `documents` parameters.<br/>
    /// **Note**: This parameter is only compatible with models [Command R 08-2024](https://docs.cohere.com/v2/docs/command-r#august-2024-release), [Command R+ 08-2024](https://docs.cohere.com/v2/docs/command-r-plus#august-2024-release) and newer.
    /// </summary>
    public enum Chatv2RequestSafetyMode
    {
        /// <summary>
        /// //docs.cohere.com/v2/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.
        /// </summary>
        CONTEXTUAL,
        /// <summary>
        /// 
        /// </summary>
        STRICT,
        /// <summary>
        /// 
        /// </summary>
        OFF,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Chatv2RequestSafetyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Chatv2RequestSafetyMode value)
        {
            return value switch
            {
                Chatv2RequestSafetyMode.CONTEXTUAL => "CONTEXTUAL",
                Chatv2RequestSafetyMode.STRICT => "STRICT",
                Chatv2RequestSafetyMode.OFF => "OFF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Chatv2RequestSafetyMode? ToEnum(string value)
        {
            return value switch
            {
                "CONTEXTUAL" => Chatv2RequestSafetyMode.CONTEXTUAL,
                "STRICT" => Chatv2RequestSafetyMode.STRICT,
                "OFF" => Chatv2RequestSafetyMode.OFF,
                _ => null,
            };
        }
    }
}