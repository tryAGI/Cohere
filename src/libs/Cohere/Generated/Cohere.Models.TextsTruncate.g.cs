
#nullable enable

namespace Cohere
{
    /// <summary>
    /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
    /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
    /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
    /// Default Value: END
    /// </summary>
    public enum TextsTruncate
    {
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
        START,
        /// <summary>
        /// 
        /// </summary>
        END,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextsTruncateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextsTruncate value)
        {
            return value switch
            {
                TextsTruncate.NONE => "NONE",
                TextsTruncate.START => "START",
                TextsTruncate.END => "END",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextsTruncate? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => TextsTruncate.NONE,
                "START" => TextsTruncate.START,
                "END" => TextsTruncate.END,
                _ => null,
            };
        }
    }
}