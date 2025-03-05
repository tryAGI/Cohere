
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentDeltaEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::Cohere.ChatContentDeltaEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::Cohere.LogprobItem? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="index"></param>
        /// <param name="logprobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentDeltaEventVariant2(
            global::Cohere.ChatContentDeltaEventVariant2Delta? delta,
            int? index,
            global::Cohere.LogprobItem? logprobs)
        {
            this.Delta = delta;
            this.Index = index;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEventVariant2" /> class.
        /// </summary>
        public ChatContentDeltaEventVariant2()
        {
        }
    }
}