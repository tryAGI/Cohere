
#nullable enable

namespace Cohere
{
    /// <summary>
    /// A table content block.
    /// </summary>
    public sealed partial class ParseTableContentBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseTableContentBlockTypeJsonConverter))]
        public global::Cohere.ParseTableContentBlockType Type { get; set; }

        /// <summary>
        /// Payload for a table block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseTableBlock Table { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseTableContentBlock" /> class.
        /// </summary>
        /// <param name="table">
        /// Payload for a table block.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseTableContentBlock(
            global::Cohere.ParseTableBlock table,
            global::Cohere.ParseTableContentBlockType type)
        {
            this.Type = type;
            this.Table = table ?? throw new global::System.ArgumentNullException(nameof(table));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseTableContentBlock" /> class.
        /// </summary>
        public ParseTableContentBlock()
        {
        }

    }
}