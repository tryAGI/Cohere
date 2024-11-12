
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NonStreamedChatResponse
    {
        /// <summary>
        /// Contents of the reply generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public global::System.Guid? GenerationId { get; set; }

        /// <summary>
        /// Unique identifier for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public global::System.Guid? ResponseId { get; set; }

        /// <summary>
        /// Inline citations for the generated reply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Cohere.ChatCitation>? Citations { get; set; }

        /// <summary>
        /// Documents seen by the model when generating the reply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::Cohere.ChatDocument>? Documents { get; set; }

        /// <summary>
        /// Denotes that a search for documents is required during the RAG flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_search_required")]
        public bool? IsSearchRequired { get; set; }

        /// <summary>
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_queries")]
        public global::System.Collections.Generic.IList<global::Cohere.ChatSearchQuery>? SearchQueries { get; set; }

        /// <summary>
        /// Documents retrieved from each of the conducted searches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::System.Collections.Generic.IList<global::Cohere.ChatSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.FinishReasonJsonConverter))]
        public global::Cohere.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Cohere.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// A list of previous messages between the user and the model, meant to give the model conversational context for responding to the user's `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_history")]
        public global::System.Collections.Generic.IList<global::Cohere.Message>? ChatHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Cohere.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NonStreamedChatResponse" /> class.
        /// </summary>
        /// <param name="text">
        /// Contents of the reply generated by the model.
        /// </param>
        /// <param name="generationId">
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </param>
        /// <param name="responseId">
        /// Unique identifier for the response.
        /// </param>
        /// <param name="citations">
        /// Inline citations for the generated reply.
        /// </param>
        /// <param name="documents">
        /// Documents seen by the model when generating the reply.
        /// </param>
        /// <param name="isSearchRequired">
        /// Denotes that a search for documents is required during the RAG flow.
        /// </param>
        /// <param name="searchQueries">
        /// Generated search queries, meant to be used as part of the RAG flow.
        /// </param>
        /// <param name="searchResults">
        /// Documents retrieved from each of the conducted searches.
        /// </param>
        /// <param name="finishReason"></param>
        /// <param name="toolCalls"></param>
        /// <param name="chatHistory">
        /// A list of previous messages between the user and the model, meant to give the model conversational context for responding to the user's `message`.
        /// </param>
        /// <param name="meta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public NonStreamedChatResponse(
            string text,
            global::System.Guid? generationId,
            global::System.Guid? responseId,
            global::System.Collections.Generic.IList<global::Cohere.ChatCitation>? citations,
            global::System.Collections.Generic.IList<global::Cohere.ChatDocument>? documents,
            bool? isSearchRequired,
            global::System.Collections.Generic.IList<global::Cohere.ChatSearchQuery>? searchQueries,
            global::System.Collections.Generic.IList<global::Cohere.ChatSearchResult>? searchResults,
            global::Cohere.FinishReason? finishReason,
            global::System.Collections.Generic.IList<global::Cohere.ToolCall>? toolCalls,
            global::System.Collections.Generic.IList<global::Cohere.Message>? chatHistory,
            global::Cohere.ApiMeta? meta)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.GenerationId = generationId;
            this.ResponseId = responseId;
            this.Citations = citations;
            this.Documents = documents;
            this.IsSearchRequired = isSearchRequired;
            this.SearchQueries = searchQueries;
            this.SearchResults = searchResults;
            this.FinishReason = finishReason;
            this.ToolCalls = toolCalls;
            this.ChatHistory = chatHistory;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NonStreamedChatResponse" /> class.
        /// </summary>
        public NonStreamedChatResponse()
        {
        }
    }
}