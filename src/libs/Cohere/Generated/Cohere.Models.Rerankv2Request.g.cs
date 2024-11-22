
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Rerankv2Request
    {
        /// <summary>
        /// The identifier of the model to use. <br/>
        /// Supported models:<br/>
        ///   - `rerank-english-v3.0`<br/>
        ///   - `rerank-multilingual-v3.0`<br/>
        ///   - `rerank-english-v2.0`<br/>
        ///   - `rerank-multilingual-v2.0`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// A list of texts that will be compared to the `query`.<br/>
        /// For optimal performance we recommend against sending more than 1,000 documents in a single request.<br/>
        /// **Note**: long documents will automatically be truncated to the value of `max_tokens_per_doc`.<br/>
        /// **Note**: structured data should be formatted as YAML strings for best performance.  
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.RerankDocument>> Documents { get; set; }

        /// <summary>
        /// Limits the returned number of rerank results to the specified value. If not passed, all the rerank results will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// - If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request.<br/>
        /// - If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// Defaults to `4096`. Long documents will be automatically truncated to the specified number of tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_per_doc")]
        public int? MaxTokensPerDoc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rerankv2Request" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model to use. <br/>
        /// Supported models:<br/>
        ///   - `rerank-english-v3.0`<br/>
        ///   - `rerank-multilingual-v3.0`<br/>
        ///   - `rerank-english-v2.0`<br/>
        ///   - `rerank-multilingual-v2.0`
        /// </param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="documents">
        /// A list of texts that will be compared to the `query`.<br/>
        /// For optimal performance we recommend against sending more than 1,000 documents in a single request.<br/>
        /// **Note**: long documents will automatically be truncated to the value of `max_tokens_per_doc`.<br/>
        /// **Note**: structured data should be formatted as YAML strings for best performance.  
        /// </param>
        /// <param name="topN">
        /// Limits the returned number of rerank results to the specified value. If not passed, all the rerank results will be returned.
        /// </param>
        /// <param name="returnDocuments">
        /// - If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request.<br/>
        /// - If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxTokensPerDoc">
        /// Defaults to `4096`. Long documents will be automatically truncated to the specified number of tokens.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Rerankv2Request(
            string model,
            string query,
            global::System.Collections.Generic.IList<global::Cohere.OneOf<string, global::Cohere.RerankDocument>> documents,
            int? topN,
            bool? returnDocuments,
            int? maxTokensPerDoc)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.TopN = topN;
            this.ReturnDocuments = returnDocuments;
            this.MaxTokensPerDoc = maxTokensPerDoc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rerankv2Request" /> class.
        /// </summary>
        public Rerankv2Request()
        {
        }
    }
}