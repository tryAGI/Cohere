
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListEmbedJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_jobs")]
        public global::System.Collections.Generic.IList<global::Cohere.EmbedJob>? EmbedJobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmbedJobResponse" /> class.
        /// </summary>
        /// <param name="embedJobs"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListEmbedJobResponse(
            global::System.Collections.Generic.IList<global::Cohere.EmbedJob>? embedJobs)
        {
            this.EmbedJobs = embedJobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmbedJobResponse" /> class.
        /// </summary>
        public ListEmbedJobResponse()
        {
        }
    }
}