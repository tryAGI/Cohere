
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamEndVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_finished")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinished { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.FinishReasonJsonConverter))]
        public global::Cohere.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.GenerateStreamEndVariant2Response Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndVariant2" /> class.
        /// </summary>
        /// <param name="isFinished"></param>
        /// <param name="finishReason"></param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateStreamEndVariant2(
            bool isFinished,
            global::Cohere.GenerateStreamEndVariant2Response response,
            global::Cohere.FinishReason? finishReason)
        {
            this.IsFinished = isFinished;
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndVariant2" /> class.
        /// </summary>
        public GenerateStreamEndVariant2()
        {
        }
    }
}