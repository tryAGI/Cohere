using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// Represents a single message in the chat history from a given role.
    /// </summary>
    public readonly partial struct ChatMessage2 : global::System.IEquatable<ChatMessage2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.SystemMessage? SystemMessage { get; init; }
#else
        public global::Cohere.SystemMessage? SystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessage2(global::Cohere.SystemMessage value) => new ChatMessage2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.SystemMessage?(ChatMessage2 @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(global::Cohere.SystemMessage? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.UserMessage? UserMessage { get; init; }
#else
        public global::Cohere.UserMessage? UserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessage2(global::Cohere.UserMessage value) => new ChatMessage2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.UserMessage?(ChatMessage2 @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(global::Cohere.UserMessage? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.AssistantMessage? AssistantMessage { get; init; }
#else
        public global::Cohere.AssistantMessage? AssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantMessage))]
#endif
        public bool IsAssistantMessage => AssistantMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessage2(global::Cohere.AssistantMessage value) => new ChatMessage2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.AssistantMessage?(ChatMessage2 @this) => @this.AssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(global::Cohere.AssistantMessage? value)
        {
            AssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ToolMessage2? Tool { get; init; }
#else
        public global::Cohere.ToolMessage2? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessage2(global::Cohere.ToolMessage2 value) => new ChatMessage2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ToolMessage2?(ChatMessage2 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(global::Cohere.ToolMessage2? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessage2(
            global::Cohere.SystemMessage? systemMessage,
            global::Cohere.UserMessage? userMessage,
            global::Cohere.AssistantMessage? assistantMessage,
            global::Cohere.ToolMessage2? tool
            )
        {
            SystemMessage = systemMessage;
            UserMessage = userMessage;
            AssistantMessage = assistantMessage;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            AssistantMessage as object ??
            UserMessage as object ??
            SystemMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystemMessage && !IsUserMessage && !IsAssistantMessage && !IsTool || !IsSystemMessage && IsUserMessage && !IsAssistantMessage && !IsTool || !IsSystemMessage && !IsUserMessage && IsAssistantMessage && !IsTool || !IsSystemMessage && !IsUserMessage && !IsAssistantMessage && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SystemMessage,
                typeof(global::Cohere.SystemMessage),
                UserMessage,
                typeof(global::Cohere.UserMessage),
                AssistantMessage,
                typeof(global::Cohere.AssistantMessage),
                Tool,
                typeof(global::Cohere.ToolMessage2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatMessage2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.SystemMessage?>.Default.Equals(SystemMessage, other.SystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.UserMessage?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.AssistantMessage?>.Default.Equals(AssistantMessage, other.AssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ToolMessage2?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessage2 obj1, ChatMessage2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessage2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessage2 obj1, ChatMessage2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessage2 o && Equals(o);
        }
    }
}
