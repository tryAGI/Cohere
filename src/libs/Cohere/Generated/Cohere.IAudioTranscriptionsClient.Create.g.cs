#nullable enable

namespace Cohere
{
    public partial interface IAudioTranscriptionsClient
    {
        /// <summary>
        /// Create a transcription<br/>
        /// Transcribe an audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.AudioTranscriptionsCreateResponse> CreateAsync(

            global::Cohere.AudioTranscriptionsCreateRequest request,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a transcription<br/>
        /// Transcribe an audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.AutoSDKHttpResponse<global::Cohere.AudioTranscriptionsCreateResponse>> CreateAsResponseAsync(

            global::Cohere.AudioTranscriptionsCreateRequest request,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a transcription<br/>
        /// Transcribe an audio file.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="language">
        /// The language of the input audio, supplied in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) format.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 make the output more random, while lower values like 0.2 make it more focused and deterministic.
        /// </param>
        /// <param name="file">
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </param>
        /// <param name="filename">
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.AudioTranscriptionsCreateResponse> CreateAsync(
            string model,
            string language,
            byte[] file,
            string filename,
            double? temperature = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a transcription<br/>
        /// Transcribe an audio file.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="language">
        /// The language of the input audio, supplied in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) format.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 make the output more random, while lower values like 0.2 make it more focused and deterministic.
        /// </param>
        /// <param name="file">
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </param>
        /// <param name="filename">
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.AudioTranscriptionsCreateResponse> CreateAsync(
            string model,
            string language,
            global::System.IO.Stream file,
            string filename,
            double? temperature = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a transcription<br/>
        /// Transcribe an audio file.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="language">
        /// The language of the input audio, supplied in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) format.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 make the output more random, while lower values like 0.2 make it more focused and deterministic.
        /// </param>
        /// <param name="file">
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </param>
        /// <param name="filename">
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cohere.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.AutoSDKHttpResponse<global::Cohere.AudioTranscriptionsCreateResponse>> CreateAsResponseAsync(
            string model,
            string language,
            global::System.IO.Stream file,
            string filename,
            double? temperature = default,
            global::Cohere.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}