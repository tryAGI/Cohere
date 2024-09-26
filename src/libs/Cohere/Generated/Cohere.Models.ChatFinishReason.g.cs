
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The reason a chat request has finished.<br/>
    /// - **complete**: The model finished sending a complete message.<br/>
    /// - **max_tokens**: The number of generated tokens exceeded the model's context length or the value specified via the `max_tokens` parameter.<br/>
    /// - **stop_sequence**: One of the provided `stop_sequence` entries was reached in the model's generation.<br/>
    /// - **tool_call**: The model generated a Tool Call and is expecting a Tool Message in return<br/>
    /// - **error**: The generation failed due to an internal error
    /// </summary>
    public enum ChatFinishReason
    {
        /// <summary>
        /// The model finished sending a complete message.
        /// </summary>
        Complete,
        /// <summary>
        /// One of the provided `stop_sequence` entries was reached in the model's generation.
        /// </summary>
        StopSequence,
        /// <summary>
        /// The number of generated tokens exceeded the model's context length or the value specified via the `max_tokens` parameter.
        /// </summary>
        MaxTokens,
        /// <summary>
        /// The model generated a Tool Call and is expecting a Tool Message in return
        /// </summary>
        ToolCall,
        /// <summary>
        /// The generation failed due to an internal error
        /// </summary>
        Error,
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
                ChatFinishReason.Complete => "complete",
                ChatFinishReason.StopSequence => "stop_sequence",
                ChatFinishReason.MaxTokens => "max_tokens",
                ChatFinishReason.ToolCall => "tool_call",
                ChatFinishReason.Error => "error",
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
                "complete" => ChatFinishReason.Complete,
                "stop_sequence" => ChatFinishReason.StopSequence,
                "max_tokens" => ChatFinishReason.MaxTokens,
                "tool_call" => ChatFinishReason.ToolCall,
                "error" => ChatFinishReason.Error,
                _ => null,
            };
        }
    }
}