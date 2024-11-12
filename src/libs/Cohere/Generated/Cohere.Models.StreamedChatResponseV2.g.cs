#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// StreamedChatResponse is returned in streaming mode (specified with `stream=True` in the request).
    /// </summary>
    public readonly partial struct StreamedChatResponseV2 : global::System.IEquatable<StreamedChatResponseV2>
    {
        /// <summary>
        /// A streamed event which signifies that a stream has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatMessageStartEvent? MessageStartEvent { get; init; }
#else
        public global::Cohere.ChatMessageStartEvent? MessageStartEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStartEvent))]
#endif
        public bool IsMessageStartEvent => MessageStartEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatMessageStartEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessageStartEvent?(StreamedChatResponseV2 @this) => @this.MessageStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatMessageStartEvent? value)
        {
            MessageStartEvent = value;
        }

        /// <summary>
        /// A streamed delta event which signifies that a new content block has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatContentStartEvent? ContentStartEvent { get; init; }
#else
        public global::Cohere.ChatContentStartEvent? ContentStartEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentStartEvent))]
#endif
        public bool IsContentStartEvent => ContentStartEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatContentStartEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentStartEvent?(StreamedChatResponseV2 @this) => @this.ContentStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatContentStartEvent? value)
        {
            ContentStartEvent = value;
        }

        /// <summary>
        /// A streamed delta event which contains a delta of chat text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatContentDeltaEvent? ContentDeltaEvent { get; init; }
#else
        public global::Cohere.ChatContentDeltaEvent? ContentDeltaEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentDeltaEvent))]
#endif
        public bool IsContentDeltaEvent => ContentDeltaEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatContentDeltaEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentDeltaEvent?(StreamedChatResponseV2 @this) => @this.ContentDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatContentDeltaEvent? value)
        {
            ContentDeltaEvent = value;
        }

        /// <summary>
        /// A streamed delta event which signifies that the content block has ended.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatContentEndEvent? ContentEndEvent { get; init; }
#else
        public global::Cohere.ChatContentEndEvent? ContentEndEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentEndEvent))]
#endif
        public bool IsContentEndEvent => ContentEndEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatContentEndEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentEndEvent?(StreamedChatResponseV2 @this) => @this.ContentEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatContentEndEvent? value)
        {
            ContentEndEvent = value;
        }

        /// <summary>
        /// A streamed event which contains a delta of tool plan text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolPlanDeltaEvent? ToolPlanDeltaEvent { get; init; }
#else
        public global::Cohere.ChatToolPlanDeltaEvent? ToolPlanDeltaEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolPlanDeltaEvent))]
#endif
        public bool IsToolPlanDeltaEvent => ToolPlanDeltaEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatToolPlanDeltaEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolPlanDeltaEvent?(StreamedChatResponseV2 @this) => @this.ToolPlanDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatToolPlanDeltaEvent? value)
        {
            ToolPlanDeltaEvent = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a tool call has started streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallStartEvent? ToolCallStartEvent { get; init; }
#else
        public global::Cohere.ChatToolCallStartEvent? ToolCallStartEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallStartEvent))]
#endif
        public bool IsToolCallStartEvent => ToolCallStartEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatToolCallStartEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallStartEvent?(StreamedChatResponseV2 @this) => @this.ToolCallStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatToolCallStartEvent? value)
        {
            ToolCallStartEvent = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a delta in tool call arguments.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallDeltaEvent? ToolCallDeltaEvent { get; init; }
#else
        public global::Cohere.ChatToolCallDeltaEvent? ToolCallDeltaEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallDeltaEvent))]
#endif
        public bool IsToolCallDeltaEvent => ToolCallDeltaEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatToolCallDeltaEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallDeltaEvent?(StreamedChatResponseV2 @this) => @this.ToolCallDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatToolCallDeltaEvent? value)
        {
            ToolCallDeltaEvent = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a tool call has finished streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallEndEvent? ToolCallEndEvent { get; init; }
#else
        public global::Cohere.ChatToolCallEndEvent? ToolCallEndEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallEndEvent))]
#endif
        public bool IsToolCallEndEvent => ToolCallEndEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatToolCallEndEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallEndEvent?(StreamedChatResponseV2 @this) => @this.ToolCallEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatToolCallEndEvent? value)
        {
            ToolCallEndEvent = value;
        }

        /// <summary>
        /// A streamed event which signifies that the chat message has ended.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatMessageEndEvent? MessageEndEvent { get; init; }
#else
        public global::Cohere.ChatMessageEndEvent? MessageEndEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageEndEvent))]
#endif
        public bool IsMessageEndEvent => MessageEndEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatMessageEndEvent value) => new StreamedChatResponseV2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessageEndEvent?(StreamedChatResponseV2 @this) => @this.MessageEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatMessageEndEvent? value)
        {
            MessageEndEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(
            global::Cohere.ChatMessageStartEvent? messageStartEvent,
            global::Cohere.ChatContentStartEvent? contentStartEvent,
            global::Cohere.ChatContentDeltaEvent? contentDeltaEvent,
            global::Cohere.ChatContentEndEvent? contentEndEvent,
            global::Cohere.ChatToolPlanDeltaEvent? toolPlanDeltaEvent,
            global::Cohere.ChatToolCallStartEvent? toolCallStartEvent,
            global::Cohere.ChatToolCallDeltaEvent? toolCallDeltaEvent,
            global::Cohere.ChatToolCallEndEvent? toolCallEndEvent,
            global::Cohere.ChatMessageEndEvent? messageEndEvent
            )
        {
            MessageStartEvent = messageStartEvent;
            ContentStartEvent = contentStartEvent;
            ContentDeltaEvent = contentDeltaEvent;
            ContentEndEvent = contentEndEvent;
            ToolPlanDeltaEvent = toolPlanDeltaEvent;
            ToolCallStartEvent = toolCallStartEvent;
            ToolCallDeltaEvent = toolCallDeltaEvent;
            ToolCallEndEvent = toolCallEndEvent;
            MessageEndEvent = messageEndEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageEndEvent as object ??
            ToolCallEndEvent as object ??
            ToolCallDeltaEvent as object ??
            ToolCallStartEvent as object ??
            ToolPlanDeltaEvent as object ??
            ContentEndEvent as object ??
            ContentDeltaEvent as object ??
            ContentStartEvent as object ??
            MessageStartEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && IsToolCallDeltaEvent && !IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && IsToolCallEndEvent && !IsMessageEndEvent || !IsMessageStartEvent && !IsContentStartEvent && !IsContentDeltaEvent && !IsContentEndEvent && !IsToolPlanDeltaEvent && !IsToolCallStartEvent && !IsToolCallDeltaEvent && !IsToolCallEndEvent && IsMessageEndEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatMessageStartEvent?, TResult>? messageStartEvent = null,
            global::System.Func<global::Cohere.ChatContentStartEvent?, TResult>? contentStartEvent = null,
            global::System.Func<global::Cohere.ChatContentDeltaEvent?, TResult>? contentDeltaEvent = null,
            global::System.Func<global::Cohere.ChatContentEndEvent?, TResult>? contentEndEvent = null,
            global::System.Func<global::Cohere.ChatToolPlanDeltaEvent?, TResult>? toolPlanDeltaEvent = null,
            global::System.Func<global::Cohere.ChatToolCallStartEvent?, TResult>? toolCallStartEvent = null,
            global::System.Func<global::Cohere.ChatToolCallDeltaEvent?, TResult>? toolCallDeltaEvent = null,
            global::System.Func<global::Cohere.ChatToolCallEndEvent?, TResult>? toolCallEndEvent = null,
            global::System.Func<global::Cohere.ChatMessageEndEvent?, TResult>? messageEndEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStartEvent && messageStartEvent != null)
            {
                return messageStartEvent(MessageStartEvent!);
            }
            else if (IsContentStartEvent && contentStartEvent != null)
            {
                return contentStartEvent(ContentStartEvent!);
            }
            else if (IsContentDeltaEvent && contentDeltaEvent != null)
            {
                return contentDeltaEvent(ContentDeltaEvent!);
            }
            else if (IsContentEndEvent && contentEndEvent != null)
            {
                return contentEndEvent(ContentEndEvent!);
            }
            else if (IsToolPlanDeltaEvent && toolPlanDeltaEvent != null)
            {
                return toolPlanDeltaEvent(ToolPlanDeltaEvent!);
            }
            else if (IsToolCallStartEvent && toolCallStartEvent != null)
            {
                return toolCallStartEvent(ToolCallStartEvent!);
            }
            else if (IsToolCallDeltaEvent && toolCallDeltaEvent != null)
            {
                return toolCallDeltaEvent(ToolCallDeltaEvent!);
            }
            else if (IsToolCallEndEvent && toolCallEndEvent != null)
            {
                return toolCallEndEvent(ToolCallEndEvent!);
            }
            else if (IsMessageEndEvent && messageEndEvent != null)
            {
                return messageEndEvent(MessageEndEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatMessageStartEvent?>? messageStartEvent = null,
            global::System.Action<global::Cohere.ChatContentStartEvent?>? contentStartEvent = null,
            global::System.Action<global::Cohere.ChatContentDeltaEvent?>? contentDeltaEvent = null,
            global::System.Action<global::Cohere.ChatContentEndEvent?>? contentEndEvent = null,
            global::System.Action<global::Cohere.ChatToolPlanDeltaEvent?>? toolPlanDeltaEvent = null,
            global::System.Action<global::Cohere.ChatToolCallStartEvent?>? toolCallStartEvent = null,
            global::System.Action<global::Cohere.ChatToolCallDeltaEvent?>? toolCallDeltaEvent = null,
            global::System.Action<global::Cohere.ChatToolCallEndEvent?>? toolCallEndEvent = null,
            global::System.Action<global::Cohere.ChatMessageEndEvent?>? messageEndEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStartEvent)
            {
                messageStartEvent?.Invoke(MessageStartEvent!);
            }
            else if (IsContentStartEvent)
            {
                contentStartEvent?.Invoke(ContentStartEvent!);
            }
            else if (IsContentDeltaEvent)
            {
                contentDeltaEvent?.Invoke(ContentDeltaEvent!);
            }
            else if (IsContentEndEvent)
            {
                contentEndEvent?.Invoke(ContentEndEvent!);
            }
            else if (IsToolPlanDeltaEvent)
            {
                toolPlanDeltaEvent?.Invoke(ToolPlanDeltaEvent!);
            }
            else if (IsToolCallStartEvent)
            {
                toolCallStartEvent?.Invoke(ToolCallStartEvent!);
            }
            else if (IsToolCallDeltaEvent)
            {
                toolCallDeltaEvent?.Invoke(ToolCallDeltaEvent!);
            }
            else if (IsToolCallEndEvent)
            {
                toolCallEndEvent?.Invoke(ToolCallEndEvent!);
            }
            else if (IsMessageEndEvent)
            {
                messageEndEvent?.Invoke(MessageEndEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStartEvent,
                typeof(global::Cohere.ChatMessageStartEvent),
                ContentStartEvent,
                typeof(global::Cohere.ChatContentStartEvent),
                ContentDeltaEvent,
                typeof(global::Cohere.ChatContentDeltaEvent),
                ContentEndEvent,
                typeof(global::Cohere.ChatContentEndEvent),
                ToolPlanDeltaEvent,
                typeof(global::Cohere.ChatToolPlanDeltaEvent),
                ToolCallStartEvent,
                typeof(global::Cohere.ChatToolCallStartEvent),
                ToolCallDeltaEvent,
                typeof(global::Cohere.ChatToolCallDeltaEvent),
                ToolCallEndEvent,
                typeof(global::Cohere.ChatToolCallEndEvent),
                MessageEndEvent,
                typeof(global::Cohere.ChatMessageEndEvent),
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
        public bool Equals(StreamedChatResponseV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatMessageStartEvent?>.Default.Equals(MessageStartEvent, other.MessageStartEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatContentStartEvent?>.Default.Equals(ContentStartEvent, other.ContentStartEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatContentDeltaEvent?>.Default.Equals(ContentDeltaEvent, other.ContentDeltaEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatContentEndEvent?>.Default.Equals(ContentEndEvent, other.ContentEndEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolPlanDeltaEvent?>.Default.Equals(ToolPlanDeltaEvent, other.ToolPlanDeltaEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallStartEvent?>.Default.Equals(ToolCallStartEvent, other.ToolCallStartEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallDeltaEvent?>.Default.Equals(ToolCallDeltaEvent, other.ToolCallDeltaEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallEndEvent?>.Default.Equals(ToolCallEndEvent, other.ToolCallEndEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatMessageEndEvent?>.Default.Equals(MessageEndEvent, other.MessageEndEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamedChatResponseV2 obj1, StreamedChatResponseV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamedChatResponseV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamedChatResponseV2 obj1, StreamedChatResponseV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamedChatResponseV2 o && Equals(o);
        }
    }
}
