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
        public global::Cohere.ChatMessage? CHATBOT { get; init; }
#else
        public global::Cohere.ChatMessage? CHATBOT { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CHATBOT))]
#endif
        public bool IsCHATBOT => CHATBOT != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::Cohere.ChatMessage value) => new Message((global::Cohere.ChatMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessage?(Message @this) => @this.CHATBOT;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::Cohere.ChatMessage? value)
        {
            CHATBOT = value;
        }

        /// <summary>
        /// Represents tool result in the chat history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolMessage? TOOL { get; init; }
#else
        public global::Cohere.ChatToolMessage? TOOL { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TOOL))]
#endif
        public bool IsTOOL => TOOL != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::Cohere.ChatToolMessage value) => new Message((global::Cohere.ChatToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolMessage?(Message @this) => @this.TOOL;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::Cohere.ChatToolMessage? value)
        {
            TOOL = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Message(
            global::Cohere.MessageDiscriminatorRole? role,
            global::Cohere.ChatMessage? cHATBOT,
            global::Cohere.ChatToolMessage? tOOL
            )
        {
            Role = role;

            CHATBOT = cHATBOT;
            TOOL = tOOL;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TOOL as object ??
            CHATBOT as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CHATBOT?.ToString() ??
            TOOL?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCHATBOT && !IsTOOL || !IsCHATBOT && IsTOOL;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatMessage?, TResult>? cHATBOT = null,
            global::System.Func<global::Cohere.ChatToolMessage?, TResult>? tOOL = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCHATBOT && cHATBOT != null)
            {
                return cHATBOT(CHATBOT!);
            }
            else if (IsTOOL && tOOL != null)
            {
                return tOOL(TOOL!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatMessage?>? cHATBOT = null,
            global::System.Action<global::Cohere.ChatToolMessage?>? tOOL = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCHATBOT)
            {
                cHATBOT?.Invoke(CHATBOT!);
            }
            else if (IsTOOL)
            {
                tOOL?.Invoke(TOOL!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CHATBOT,
                typeof(global::Cohere.ChatMessage),
                TOOL,
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
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatMessage?>.Default.Equals(CHATBOT, other.CHATBOT) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolMessage?>.Default.Equals(TOOL, other.TOOL) 
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
