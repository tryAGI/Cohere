
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Discriminator for the document payload.
    /// </summary>
    public enum ParseDocumentType
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseDocumentType value)
        {
            return value switch
            {
                ParseDocumentType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ParseDocumentType.ImageUrl,
                _ => null,
            };
        }
    }
}