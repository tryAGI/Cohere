
#nullable enable

namespace Cohere
{
    public sealed partial class CohereApi
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _httpClient.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                scheme: "Bearer",
                parameter: apiKey);
        }
    }
}