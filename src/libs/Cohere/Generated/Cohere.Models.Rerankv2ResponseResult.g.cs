
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Rerankv2ResponseResult
    {
        /// <summary>
        /// If `return_documents` is set as `false` this will return none, if `true` it will return the documents passed in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Cohere.Rerankv2ResponseResultDocument? Document { get; set; }

        /// <summary>
        /// Corresponds to the index in the original list of documents to which the ranked document belongs. (i.e. if the first value in the `results` object has an `index` value of 3, it means in the list of documents passed in, the document at `index=3` had the highest relevance)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Relevance scores are normalized to be in the range `[0, 1]`. Scores close to `1` indicate a high relevance to the query, and scores closer to `0` indicate low relevance. It is not accurate to assume a score of 0.9 means the document is 2x more relevant than a document with a score of 0.45<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        public float RelevanceScore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rerankv2ResponseResult" /> class.
        /// </summary>
        /// <param name="document">
        /// If `return_documents` is set as `false` this will return none, if `true` it will return the documents passed in
        /// </param>
        /// <param name="index">
        /// Corresponds to the index in the original list of documents to which the ranked document belongs. (i.e. if the first value in the `results` object has an `index` value of 3, it means in the list of documents passed in, the document at `index=3` had the highest relevance)
        /// </param>
        /// <param name="relevanceScore">
        /// Relevance scores are normalized to be in the range `[0, 1]`. Scores close to `1` indicate a high relevance to the query, and scores closer to `0` indicate low relevance. It is not accurate to assume a score of 0.9 means the document is 2x more relevant than a document with a score of 0.45<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Rerankv2ResponseResult(
            int index,
            global::Cohere.Rerankv2ResponseResultDocument? document,
            float relevanceScore = default!)
        {
            this.Index = index;
            this.Document = document;
            this.RelevanceScore = relevanceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rerankv2ResponseResult" /> class.
        /// </summary>
        public Rerankv2ResponseResult()
        {
        }
    }
}