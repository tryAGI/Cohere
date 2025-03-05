
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageEndEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::Cohere.ChatMessageEndEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageEndEventVariant2" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessageEndEventVariant2(
            global::Cohere.ChatMessageEndEventVariant2Delta? delta,
            string? id)
        {
            this.Delta = delta;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageEndEventVariant2" /> class.
        /// </summary>
        public ChatMessageEndEventVariant2()
        {
        }
    }
}