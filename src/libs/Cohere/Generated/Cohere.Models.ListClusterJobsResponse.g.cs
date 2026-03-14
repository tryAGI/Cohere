
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListClusterJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cohere.GetClusterJobResponse> Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

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
        /// Initializes a new instance of the <see cref="ListClusterJobsResponse" /> class.
        /// </summary>
        /// <param name="jobs"></param>
        /// <param name="totalCount"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListClusterJobsResponse(
            global::System.Collections.Generic.IList<global::Cohere.GetClusterJobResponse> jobs,
            int? totalCount,
            global::Cohere.ApiMeta? meta)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
            this.TotalCount = totalCount;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListClusterJobsResponse" /> class.
        /// </summary>
        public ListClusterJobsResponse()
        {
        }
    }
}