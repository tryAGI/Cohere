
#nullable enable

namespace Cohere
{
    /// <summary>
    /// An image content block.
    /// </summary>
    public sealed partial class ParseImageContentBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseImageContentBlockTypeJsonConverter))]
        public global::Cohere.ParseImageContentBlockType Type { get; set; }

        /// <summary>
        /// Payload for an image block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseImageBlock Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseImageContentBlock" /> class.
        /// </summary>
        /// <param name="image">
        /// Payload for an image block.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseImageContentBlock(
            global::Cohere.ParseImageBlock image,
            global::Cohere.ParseImageContentBlockType type)
        {
            this.Type = type;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseImageContentBlock" /> class.
        /// </summary>
        public ParseImageContentBlock()
        {
        }

    }
}