
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The reason a chat request has finished.<br/>
    /// - **complete**: The model finished sending a complete message.<br/>
    /// - **max_tokens**: The number of generated tokens exceeded the model's context length or the value specified via the `max_tokens` parameter.<br/>
    /// - **stop_sequence**: One of the provided `stop_sequence` entries was reached in the model's generation.<br/>
    /// - **tool_call**: The model generated a Tool Call and is expecting a Tool Message in return<br/>
    /// - **error**: The generation failed due to an internal error<br/>
    /// - **timeout**: The generation was stopped because it exceeded the allowed time limit.
    /// </summary>
    public enum ChatFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFinishReason value)
        {
            return value switch
            {
                ChatFinishReason.Complete => "COMPLETE",
                ChatFinishReason.StopSequence => "STOP_SEQUENCE",
                ChatFinishReason.MaxTokens => "MAX_TOKENS",
                ChatFinishReason.ToolCall => "TOOL_CALL",
                ChatFinishReason.Error => "ERROR",
                ChatFinishReason.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => ChatFinishReason.Complete,
                "STOP_SEQUENCE" => ChatFinishReason.StopSequence,
                "MAX_TOKENS" => ChatFinishReason.MaxTokens,
                "TOOL_CALL" => ChatFinishReason.ToolCall,
                "ERROR" => ChatFinishReason.Error,
                "TIMEOUT" => ChatFinishReason.Timeout,
                _ => null,
            };
        }
    }
}