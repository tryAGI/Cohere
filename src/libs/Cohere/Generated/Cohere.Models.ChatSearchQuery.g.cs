
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The generated search query. Contains the text of the query and a unique identifier for the query.
    /// </summary>
    public sealed partial class ChatSearchQuery
    {
        /// <summary>
        /// The text of the search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Unique identifier for the generated search query. Useful for submitting feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQuery" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the search query.
        /// </param>
        /// <param name="generationId">
        /// Unique identifier for the generated search query. Useful for submitting feedback.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatSearchQuery(
            string text,
            global::System.Guid generationId)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.GenerationId = generationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchQuery" /> class.
        /// </summary>
        public ChatSearchQuery()
        {
        }
    }
}