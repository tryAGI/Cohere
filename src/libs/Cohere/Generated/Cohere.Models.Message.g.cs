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
        public global::Cohere.MessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// Represents a single message in the chat history, excluding the current user turn. It has two properties: `role` and `message`. The `role` identifies the sender (`CHATBOT`, `SYSTEM`, or `USER`), while the `message` contains the text content.<br/>
        /// The chat_history parameter should not be used for `SYSTEM` messages in most cases. Instead, to add a `SYSTEM` role message at the beginning of a conversation, the `preamble` parameter should be used.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatMessage? Chatbot { get; init; }
#else
        public global::Cohere.ChatMessage? Chatbot { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chatbot))]
#endif
        public bool IsChatbot => Chatbot != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatbot(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatMessage? value)
        {
            value = Chatbot;
            return IsChatbot;
        }

        /// <summary>
        /// Represents tool result in the chat history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolMessage? Tool { get; init; }
#else
        public global::Cohere.ChatToolMessage? Tool { get; }
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
        public bool TryPickTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatToolMessage? value)
        {
            value = Tool;
            return IsTool;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::Cohere.ChatMessage value) => new Message((global::Cohere.ChatMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessage?(Message @this) => @this.Chatbot;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::Cohere.ChatMessage? value)
        {
            Chatbot = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::Cohere.ChatToolMessage value) => new Message((global::Cohere.ChatToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolMessage?(Message @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::Cohere.ChatToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Message(
            global::Cohere.MessageDiscriminatorRole? role,
            global::Cohere.ChatMessage? chatbot,
            global::Cohere.ChatToolMessage? tool
            )
        {
            Role = role;

            Chatbot = chatbot;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            Chatbot as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chatbot?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatbot && !IsTool || !IsChatbot && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatMessage, TResult>? chatbot = null,
            global::System.Func<global::Cohere.ChatToolMessage, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatbot && chatbot != null)
            {
                return chatbot(Chatbot!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatMessage>? chatbot = null,

            global::System.Action<global::Cohere.ChatToolMessage>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatbot)
            {
                chatbot?.Invoke(Chatbot!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatMessage>? chatbot = null,
            global::System.Action<global::Cohere.ChatToolMessage>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatbot)
            {
                chatbot?.Invoke(Chatbot!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chatbot,
                typeof(global::Cohere.ChatMessage),
                Tool,
                typeof(global::Cohere.ChatToolMessage),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Message other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatMessage?>.Default.Equals(Chatbot, other.Chatbot) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolMessage?>.Default.Equals(Tool, other.Tool) 
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
