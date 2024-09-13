
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Defaults to `"text"`.<br/>
    /// When set to `"json_object"`, the model's output will be a valid JSON Object.
    /// </summary>
    public enum ResponseFormatType2
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatType2 value)
        {
            return value switch
            {
                ResponseFormatType2.Text => "text",
                ResponseFormatType2.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatType2? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseFormatType2.Text,
                "json_object" => ResponseFormatType2.JsonObject,
                _ => null,
            };
        }
    }
}