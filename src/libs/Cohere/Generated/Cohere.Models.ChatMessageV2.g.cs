#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// Represents a single message in the chat history from a given role.
    /// </summary>
    public readonly partial struct ChatMessageV2 : global::System.IEquatable<ChatMessageV2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.ChatMessageV2DiscriminatorRole? Role { get; }

        /// <summary>
        /// A message from the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.UserMessageV2? User { get; init; }
#else
        public global::Cohere.UserMessageV2? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageV2(global::Cohere.UserMessageV2 value) => new ChatMessageV2((global::Cohere.UserMessageV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.UserMessageV2?(ChatMessageV2 @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(global::Cohere.UserMessageV2? value)
        {
            User = value;
        }

        /// <summary>
        /// A message from the assistant role can contain text and tool call information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.AssistantMessageV2? Assistant { get; init; }
#else
        public global::Cohere.AssistantMessageV2? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageV2(global::Cohere.AssistantMessageV2 value) => new ChatMessageV2((global::Cohere.AssistantMessageV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.AssistantMessageV2?(ChatMessageV2 @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(global::Cohere.AssistantMessageV2? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// A message from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.SystemMessageV2? System { get; init; }
#else
        public global::Cohere.SystemMessageV2? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageV2(global::Cohere.SystemMessageV2 value) => new ChatMessageV2((global::Cohere.SystemMessageV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.SystemMessageV2?(ChatMessageV2 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(global::Cohere.SystemMessageV2? value)
        {
            System = value;
        }

        /// <summary>
        /// A message with Tool outputs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ToolMessageV2? Tool { get; init; }
#else
        public global::Cohere.ToolMessageV2? Tool { get; }
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
        public static implicit operator ChatMessageV2(global::Cohere.ToolMessageV2 value) => new ChatMessageV2((global::Cohere.ToolMessageV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ToolMessageV2?(ChatMessageV2 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(global::Cohere.ToolMessageV2? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageV2(
            global::Cohere.ChatMessageV2DiscriminatorRole? role,
            global::Cohere.UserMessageV2? user,
            global::Cohere.AssistantMessageV2? assistant,
            global::Cohere.SystemMessageV2? system,
            global::Cohere.ToolMessageV2? tool
            )
        {
            Role = role;

            User = user;
            Assistant = assistant;
            System = system;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            System as object ??
            Assistant as object ??
            User as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            Assistant?.ToString() ??
            System?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsAssistant && !IsSystem && !IsTool || !IsUser && IsAssistant && !IsSystem && !IsTool || !IsUser && !IsAssistant && IsSystem && !IsTool || !IsUser && !IsAssistant && !IsSystem && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.UserMessageV2?, TResult>? user = null,
            global::System.Func<global::Cohere.AssistantMessageV2?, TResult>? assistant = null,
            global::System.Func<global::Cohere.SystemMessageV2?, TResult>? system = null,
            global::System.Func<global::Cohere.ToolMessageV2?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsSystem && system != null)
            {
                return system(System!);
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
            global::System.Action<global::Cohere.UserMessageV2?>? user = null,
            global::System.Action<global::Cohere.AssistantMessageV2?>? assistant = null,
            global::System.Action<global::Cohere.SystemMessageV2?>? system = null,
            global::System.Action<global::Cohere.ToolMessageV2?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
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
                User,
                typeof(global::Cohere.UserMessageV2),
                Assistant,
                typeof(global::Cohere.AssistantMessageV2),
                System,
                typeof(global::Cohere.SystemMessageV2),
                Tool,
                typeof(global::Cohere.ToolMessageV2),
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
        public bool Equals(ChatMessageV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.UserMessageV2?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.AssistantMessageV2?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.SystemMessageV2?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ToolMessageV2?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageV2 obj1, ChatMessageV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageV2 obj1, ChatMessageV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageV2 o && Equals(o);
        }
    }
}
