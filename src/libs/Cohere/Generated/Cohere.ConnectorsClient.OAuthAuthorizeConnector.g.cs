
#nullable enable

namespace Cohere
{
    public partial class ConnectorsClient
    {
        partial void PrepareOAuthAuthorizeConnectorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string? afterTokenRedirect,
            ref string? xClientName);
        partial void PrepareOAuthAuthorizeConnectorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string? afterTokenRedirect,
            string? xClientName);
        partial void ProcessOAuthAuthorizeConnectorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOAuthAuthorizeConnectorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Authorize with oAuth<br/>
        /// Authorize the connector with the given ID for the connector oauth app.  See ['Connector Authentication'](https://docs.cohere.com/docs/connector-authentication) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="afterTokenRedirect"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Cohere.OAuthAuthorizeResponse> OAuthAuthorizeConnectorAsync(
            string id,
            string? afterTokenRedirect = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOAuthAuthorizeConnectorArguments(
                httpClient: HttpClient,
                id: ref id,
                afterTokenRedirect: ref afterTokenRedirect,
                xClientName: ref xClientName);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/connectors/{id}/oauth/authorize",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("after_token_redirect", afterTokenRedirect) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOAuthAuthorizeConnectorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                afterTokenRedirect: afterTokenRedirect,
                xClientName: xClientName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOAuthAuthorizeConnectorResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Cohere.OAuthAuthorizeConnectorResponse.FromJson(__content_400, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::Cohere.OAuthAuthorizeConnectorResponse.FromJsonStreamAsync(__contentStream_400, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse2? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Cohere.OAuthAuthorizeConnectorResponse2.FromJson(__content_401, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::Cohere.OAuthAuthorizeConnectorResponse2.FromJsonStreamAsync(__contentStream_401, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse2>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse3? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::Cohere.OAuthAuthorizeConnectorResponse3.FromJson(__content_403, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::Cohere.OAuthAuthorizeConnectorResponse3.FromJsonStreamAsync(__contentStream_403, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse3>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a resource is not found. This could be because:   - The endpoint does not exist   - The resource does not exist eg model id, dataset id 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse4? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::Cohere.OAuthAuthorizeConnectorResponse4.FromJson(__content_404, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::Cohere.OAuthAuthorizeConnectorResponse4.FromJsonStreamAsync(__contentStream_404, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse4>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse5? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::Cohere.OAuthAuthorizeConnectorResponse5.FromJson(__content_422, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::Cohere.OAuthAuthorizeConnectorResponse5.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse5>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse6? __value_429 = null;
                if (ReadResponseAsString)
                {
                    __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = global::Cohere.OAuthAuthorizeConnectorResponse6.FromJson(__content_429, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = await global::Cohere.OAuthAuthorizeConnectorResponse6.FromJsonStreamAsync(__contentStream_429, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse6>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request or response contains a deny-listed token. 
            if ((int)__response.StatusCode == 498)
            {
                string? __content_498 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse7? __value_498 = null;
                if (ReadResponseAsString)
                {
                    __content_498 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_498 = global::Cohere.OAuthAuthorizeConnectorResponse7.FromJson(__content_498, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_498 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_498 = await global::Cohere.OAuthAuthorizeConnectorResponse7.FromJsonStreamAsync(__contentStream_498, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse7>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_498,
                    ResponseObject = __value_498,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request is cancelled by the user. 
            if ((int)__response.StatusCode == 499)
            {
                string? __content_499 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse8? __value_499 = null;
                if (ReadResponseAsString)
                {
                    __content_499 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_499 = global::Cohere.OAuthAuthorizeConnectorResponse8.FromJson(__content_499, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_499 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_499 = await global::Cohere.OAuthAuthorizeConnectorResponse8.FromJsonStreamAsync(__contentStream_499, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse8>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_499,
                    ResponseObject = __value_499,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when an uncategorised internal server error occurs. 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse9? __value_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = global::Cohere.OAuthAuthorizeConnectorResponse9.FromJson(__content_500, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = await global::Cohere.OAuthAuthorizeConnectorResponse9.FromJsonStreamAsync(__contentStream_500, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse9>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the requested feature is not implemented. 
            if ((int)__response.StatusCode == 501)
            {
                string? __content_501 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse10? __value_501 = null;
                if (ReadResponseAsString)
                {
                    __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_501 = global::Cohere.OAuthAuthorizeConnectorResponse10.FromJson(__content_501, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_501 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_501 = await global::Cohere.OAuthAuthorizeConnectorResponse10.FromJsonStreamAsync(__contentStream_501, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse10>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_501,
                    ResponseObject = __value_501,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the service is unavailable. This could be due to:   - Too many users trying to access the service at the same time 
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse11? __value_503 = null;
                if (ReadResponseAsString)
                {
                    __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = global::Cohere.OAuthAuthorizeConnectorResponse11.FromJson(__content_503, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = await global::Cohere.OAuthAuthorizeConnectorResponse11.FromJsonStreamAsync(__contentStream_503, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse11>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request to the server times out. This could be due to:   - An internal services taking too long to respond 
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::Cohere.OAuthAuthorizeConnectorResponse12? __value_504 = null;
                if (ReadResponseAsString)
                {
                    __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = global::Cohere.OAuthAuthorizeConnectorResponse12.FromJson(__content_504, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_504 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = await global::Cohere.OAuthAuthorizeConnectorResponse12.FromJsonStreamAsync(__contentStream_504, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Cohere.ApiException<global::Cohere.OAuthAuthorizeConnectorResponse12>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseObject = __value_504,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessOAuthAuthorizeConnectorResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Cohere.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Cohere.OAuthAuthorizeResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Cohere.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::Cohere.OAuthAuthorizeResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}