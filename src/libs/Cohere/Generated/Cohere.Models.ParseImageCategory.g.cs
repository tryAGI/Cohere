
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Image element category.
    /// </summary>
    public enum ParseImageCategory
    {
        /// <summary>
        ///
        /// </summary>
        Flowchart,
        /// <summary>
        ///
        /// </summary>
        Logo,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        Signature,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseImageCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseImageCategory value)
        {
            return value switch
            {
                ParseImageCategory.Flowchart => "flowchart",
                ParseImageCategory.Logo => "logo",
                ParseImageCategory.Other => "other",
                ParseImageCategory.Signature => "signature",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseImageCategory? ToEnum(string value)
        {
            return value switch
            {
                "flowchart" => ParseImageCategory.Flowchart,
                "logo" => ParseImageCategory.Logo,
                "other" => ParseImageCategory.Other,
                "signature" => ParseImageCategory.Signature,
                _ => null,
            };
        }
    }
}