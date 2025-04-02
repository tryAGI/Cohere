
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedImageProperties
    {
        /// <summary>
        /// Bit depth of the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_depth")]
        public double? BitDepth { get; set; }

        /// <summary>
        /// Format of the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Height of the image in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Width of the image in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedImageProperties" /> class.
        /// </summary>
        /// <param name="bitDepth">
        /// Bit depth of the image
        /// </param>
        /// <param name="format">
        /// Format of the image
        /// </param>
        /// <param name="height">
        /// Height of the image in pixels
        /// </param>
        /// <param name="width">
        /// Width of the image in pixels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedImageProperties(
            double? bitDepth,
            string? format,
            double? height,
            double? width)
        {
            this.BitDepth = bitDepth;
            this.Format = format;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedImageProperties" /> class.
        /// </summary>
        public EmbedImageProperties()
        {
        }
    }
}