
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionsCreateRequest
    {
        /// <summary>
        /// ID of the model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The language of the input audio, supplied in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 make the output more random, while lower values like 0.2 make it more focused and deterministic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionsCreateRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="language">
        /// The language of the input audio, supplied in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) format.
        /// </param>
        /// <param name="file">
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </param>
        /// <param name="filename">
        /// The audio file object to transcribe. Supported file extensions are flac, mp3, mpeg, mpga, ogg, and wav.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 make the output more random, while lower values like 0.2 make it more focused and deterministic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionsCreateRequest(
            string model,
            string language,
            byte[] file,
            string filename,
            double? temperature)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Temperature = temperature;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionsCreateRequest" /> class.
        /// </summary>
        public AudioTranscriptionsCreateRequest()
        {
        }
    }
}