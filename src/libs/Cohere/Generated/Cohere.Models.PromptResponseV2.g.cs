
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Response from the v2 prompt endpoint — the constructed text prompt without generation.
    /// </summary>
    public sealed partial class PromptResponseV2
    {
        /// <summary>
        /// The constructed text prompt that would be sent to the model for this chat request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResponseV2" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The constructed text prompt that would be sent to the model for this chat request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptResponseV2(
            string prompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResponseV2" /> class.
        /// </summary>
        public PromptResponseV2()
        {
        }

    }
}