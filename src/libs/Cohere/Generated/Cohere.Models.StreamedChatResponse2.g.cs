using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// StreamedChatResponse is returned in streaming mode (specified with `stream=True` in the request).
    /// </summary>
    public readonly partial struct StreamedChatResponse2 : global::System.IEquatable<StreamedChatResponse2>
    {
        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatMessageStartEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessageStartEvent?(StreamedChatResponse2 @this) => @this.MessageStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatMessageStartEvent? value)
        {
            MessageStartEvent = value;
        }

        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatContentStartEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentStartEvent?(StreamedChatResponse2 @this) => @this.ContentStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatContentStartEvent? value)
        {
            ContentStartEvent = value;
        }

        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatContentDeltaEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentDeltaEvent?(StreamedChatResponse2 @this) => @this.ContentDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatContentDeltaEvent? value)
        {
            ContentDeltaEvent = value;
        }

        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatContentEndEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentEndEvent?(StreamedChatResponse2 @this) => @this.ContentEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatContentEndEvent? value)
        {
            ContentEndEvent = value;
        }

        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatToolPlanDeltaEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolPlanDeltaEvent?(StreamedChatResponse2 @this) => @this.ToolPlanDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatToolPlanDeltaEvent? value)
        {
            ToolPlanDeltaEvent = value;
        }

        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatToolCallStartEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallStartEvent?(StreamedChatResponse2 @this) => @this.ToolCallStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatToolCallStartEvent? value)
        {
            ToolCallStartEvent = value;
        }

        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatToolCallDeltaEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallDeltaEvent?(StreamedChatResponse2 @this) => @this.ToolCallDeltaEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatToolCallDeltaEvent? value)
        {
            ToolCallDeltaEvent = value;
        }

        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatToolCallEndEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallEndEvent?(StreamedChatResponse2 @this) => @this.ToolCallEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatToolCallEndEvent? value)
        {
            ToolCallEndEvent = value;
        }

        /// <summary>
        /// 
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
        public static implicit operator StreamedChatResponse2(global::Cohere.ChatMessageEndEvent value) => new StreamedChatResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessageEndEvent?(StreamedChatResponse2 @this) => @this.MessageEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(global::Cohere.ChatMessageEndEvent? value)
        {
            MessageEndEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse2(
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
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(StreamedChatResponse2 other)
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
        public static bool operator ==(StreamedChatResponse2 obj1, StreamedChatResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamedChatResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamedChatResponse2 obj1, StreamedChatResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamedChatResponse2 o && Equals(o);
        }
    }
}
