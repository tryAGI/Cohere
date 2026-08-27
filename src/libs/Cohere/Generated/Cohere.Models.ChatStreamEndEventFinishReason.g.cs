
#nullable enable

namespace Cohere
{
    /// <summary>
    /// - `COMPLETE` - the model sent back a finished reply<br/>
    /// - `ERROR_LIMIT` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
    /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens specified by the max_tokens parameter<br/>
    /// - `ERROR` - something went wrong when generating the reply<br/>
    /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
    /// </summary>
    public enum ChatStreamEndEventFinishReason
    {
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        ErrorLimit,
        /// <summary>
        ///
        /// </summary>
        ErrorToxic,
        /// <summary>
        ///
        /// </summary>
        MaxTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamEndEventFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamEndEventFinishReason value)
        {
            return value switch
            {
                ChatStreamEndEventFinishReason.Complete => "COMPLETE",
                ChatStreamEndEventFinishReason.Error => "ERROR",
                ChatStreamEndEventFinishReason.ErrorLimit => "ERROR_LIMIT",
                ChatStreamEndEventFinishReason.ErrorToxic => "ERROR_TOXIC",
                ChatStreamEndEventFinishReason.MaxTokens => "MAX_TOKENS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamEndEventFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => ChatStreamEndEventFinishReason.Complete,
                "ERROR" => ChatStreamEndEventFinishReason.Error,
                "ERROR_LIMIT" => ChatStreamEndEventFinishReason.ErrorLimit,
                "ERROR_TOXIC" => ChatStreamEndEventFinishReason.ErrorToxic,
                "MAX_TOKENS" => ChatStreamEndEventFinishReason.MaxTokens,
                _ => null,
            };
        }
    }
}