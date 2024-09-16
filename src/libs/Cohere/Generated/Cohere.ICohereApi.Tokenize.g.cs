#nullable enable

namespace Cohere
{
    public partial interface ICohereApi
    {
        /// <summary>
        /// Tokenize<br/>
        /// This endpoint splits input text into smaller units called tokens using byte-pair encoding (BPE). To learn more about tokenization and byte pair encoding, see the tokens page.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.TokenizeResponse> TokenizeAsync(
            global::Cohere.TokenizeRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Tokenize<br/>
        /// This endpoint splits input text into smaller units called tokens using byte-pair encoding (BPE). To learn more about tokenization and byte pair encoding, see the tokens page.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="text">
        /// The string to be tokenized, the minimum text length is 1 character, and the maximum text length is 65536 characters.
        /// </param>
        /// <param name="model">
        /// An optional parameter to provide the model name. This will ensure that the tokenization uses the tokenizer used by that model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cohere.TokenizeResponse> TokenizeAsync(
            string text,
            string model,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}