
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

            Authorizations.Clear();
            Authorizations.Add(new global::Cohere.EndPointAuthorization
            {
                Type = "Http",
                Location = "Header",
                Name = "Bearer",
                Value = apiKey,
            });
        }
    }
}