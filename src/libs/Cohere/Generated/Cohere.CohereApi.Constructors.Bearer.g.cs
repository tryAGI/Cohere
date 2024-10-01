
#nullable enable

namespace Cohere
{
    public sealed partial class CohereApi
    {
        /// <inheritdoc cref="CohereApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Cohere.EndPointAuthorization?)"/>
        public CohereApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Cohere.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}