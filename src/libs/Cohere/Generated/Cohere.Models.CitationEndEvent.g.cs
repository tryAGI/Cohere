#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A streamed event which signifies a citation has finished streaming.
    /// </summary>
    public readonly partial struct CitationEndEvent : global::System.IEquatable<CitationEndEvent>
    {
        /// <summary>
        /// The streamed event types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamEventType? ChatStreamType { get; init; }
#else
        public global::Cohere.ChatStreamEventType? ChatStreamType { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatStreamType))]
#endif
        public bool IsChatStreamType => ChatStreamType != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatStreamType(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatStreamEventType? value)
        {
            value = ChatStreamType;
            return IsChatStreamType;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.CitationEndEventFs3igt? Fs3igt { get; init; }
#else
        public global::Cohere.CitationEndEventFs3igt? Fs3igt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fs3igt))]
#endif
        public bool IsFs3igt => Fs3igt != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFs3igt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.CitationEndEventFs3igt? value)
        {
            value = Fs3igt;
            return IsFs3igt;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationEndEvent(global::Cohere.ChatStreamEventType value) => new CitationEndEvent((global::Cohere.ChatStreamEventType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEventType?(CitationEndEvent @this) => @this.ChatStreamType;

        /// <summary>
        /// 
        /// </summary>
        public CitationEndEvent(global::Cohere.ChatStreamEventType? value)
        {
            ChatStreamType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CitationEndEvent(global::Cohere.CitationEndEventFs3igt value) => new CitationEndEvent((global::Cohere.CitationEndEventFs3igt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.CitationEndEventFs3igt?(CitationEndEvent @this) => @this.Fs3igt;

        /// <summary>
        /// 
        /// </summary>
        public CitationEndEvent(global::Cohere.CitationEndEventFs3igt? value)
        {
            Fs3igt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CitationEndEvent(
            global::Cohere.ChatStreamEventType? chatStreamType,
            global::Cohere.CitationEndEventFs3igt? fs3igt
            )
        {
            ChatStreamType = chatStreamType;
            Fs3igt = fs3igt;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Fs3igt as object ??
            ChatStreamType as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatStreamType?.ToString() ??
            Fs3igt?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatStreamType && IsFs3igt;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatStreamEventType, TResult>? chatStreamType = null,
            global::System.Func<global::Cohere.CitationEndEventFs3igt, TResult>? fs3igt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamType && chatStreamType != null)
            {
                return chatStreamType(ChatStreamType!);
            }
            else if (IsFs3igt && fs3igt != null)
            {
                return fs3igt(Fs3igt!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatStreamEventType>? chatStreamType = null,

            global::System.Action<global::Cohere.CitationEndEventFs3igt>? fs3igt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamType)
            {
                chatStreamType?.Invoke(ChatStreamType!);
            }
            else if (IsFs3igt)
            {
                fs3igt?.Invoke(Fs3igt!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cohere.ChatStreamEventType>? chatStreamType = null,
            global::System.Action<global::Cohere.CitationEndEventFs3igt>? fs3igt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatStreamType)
            {
                chatStreamType?.Invoke(ChatStreamType!);
            }
            else if (IsFs3igt)
            {
                fs3igt?.Invoke(Fs3igt!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatStreamType,
                typeof(global::Cohere.ChatStreamEventType),
                Fs3igt,
                typeof(global::Cohere.CitationEndEventFs3igt),
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
        public bool Equals(CitationEndEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEventType?>.Default.Equals(ChatStreamType, other.ChatStreamType) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.CitationEndEventFs3igt?>.Default.Equals(Fs3igt, other.Fs3igt) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CitationEndEvent obj1, CitationEndEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CitationEndEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CitationEndEvent obj1, CitationEndEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CitationEndEvent o && Equals(o);
        }
    }
}
