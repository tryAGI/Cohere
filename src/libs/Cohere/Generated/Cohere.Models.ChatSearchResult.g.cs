
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSearchResult
    {
        /// <summary>
        /// The generated search query. Contains the text of the query and a unique identifier for the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_query")]
        public global::Cohere.ChatSearchQuery? SearchQuery { get; set; }

        /// <summary>
        /// The connector used for fetching documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ChatSearchResultConnector Connector { get; set; }

        /// <summary>
        /// Identifiers of documents found by this search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DocumentIds { get; set; }

        /// <summary>
        /// An error message if the search failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Whether a chat request should continue or not if the request to this connector fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::Cohere.ChatSearchResult? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Cohere.ChatSearchResult),
                jsonSerializerContext) as global::Cohere.ChatSearchResult;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Cohere.ChatSearchResult? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Cohere.ChatSearchResult>(
                json,
                jsonSerializerOptions);
        }

    }
}