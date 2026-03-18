
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The Cohere API for interacting with Chat, Embed and Rerank models.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ICohereClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Cohere.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Datasets API
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// Connectors API
        /// </summary>
        public ConnectorsClient Connectors { get; }

        /// <summary>
        /// Embed Jobs API
        /// </summary>
        public EmbedJobsClient EmbedJobs { get; }

        /// <summary>
        /// Finetuning API (Beta)
        /// </summary>
        public FinetuningClient Finetuning { get; }

        /// <summary>
        /// 
        /// </summary>
        public BatchesClient Batches { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

    }
}