using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Message : global::System.IEquatable<Message>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatMessage? Chat { get; init; }
#else
        public global::Cohere.ChatMessage? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::Cohere.ChatMessage value) => new Message(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessage?(Message @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::Cohere.ChatMessage? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ToolMessage? Tool { get; init; }
#else
        public global::Cohere.ToolMessage? Tool { get; }
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
        public static implicit operator Message(global::Cohere.ToolMessage value) => new Message(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ToolMessage?(Message @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::Cohere.ToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Message(
            global::Cohere.ChatMessage? chat,
            global::Cohere.ToolMessage? tool
            )
        {
            Chat = chat;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            Chat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChat && !IsTool || !IsChat && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chat,
                typeof(global::Cohere.ChatMessage),
                Tool,
                typeof(global::Cohere.ToolMessage),
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
        public bool Equals(Message other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatMessage?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ToolMessage?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Message obj1, Message obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Message>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Message obj1, Message obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Message o && Equals(o);
        }
    }
}
