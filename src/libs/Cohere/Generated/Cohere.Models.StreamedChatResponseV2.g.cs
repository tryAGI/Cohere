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
        /// 
        /// </summary>
        public global::Cohere.StreamedChatResponseV2DiscriminatorType? Type { get; }

        /// <summary>
        /// A streamed event which signifies that a stream has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatMessageStartEvent? MessageStart { get; init; }
#else
        public global::Cohere.ChatMessageStartEvent? MessageStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStart))]
#endif
        public bool IsMessageStart => MessageStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatMessageStartEvent value) => new StreamedChatResponseV2((global::Cohere.ChatMessageStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessageStartEvent?(StreamedChatResponseV2 @this) => @this.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatMessageStartEvent? value)
        {
            MessageStart = value;
        }

        /// <summary>
        /// A streamed delta event which signifies that a new content block has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatContentStartEvent? ContentStart { get; init; }
#else
        public global::Cohere.ChatContentStartEvent? ContentStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentStart))]
#endif
        public bool IsContentStart => ContentStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatContentStartEvent value) => new StreamedChatResponseV2((global::Cohere.ChatContentStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentStartEvent?(StreamedChatResponseV2 @this) => @this.ContentStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatContentStartEvent? value)
        {
            ContentStart = value;
        }

        /// <summary>
        /// A streamed delta event which contains a delta of chat text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatContentDeltaEvent? ContentDelta { get; init; }
#else
        public global::Cohere.ChatContentDeltaEvent? ContentDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentDelta))]
#endif
        public bool IsContentDelta => ContentDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatContentDeltaEvent value) => new StreamedChatResponseV2((global::Cohere.ChatContentDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentDeltaEvent?(StreamedChatResponseV2 @this) => @this.ContentDelta;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatContentDeltaEvent? value)
        {
            ContentDelta = value;
        }

        /// <summary>
        /// A streamed delta event which signifies that the content block has ended.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatContentEndEvent? ContentEnd { get; init; }
#else
        public global::Cohere.ChatContentEndEvent? ContentEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentEnd))]
#endif
        public bool IsContentEnd => ContentEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatContentEndEvent value) => new StreamedChatResponseV2((global::Cohere.ChatContentEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatContentEndEvent?(StreamedChatResponseV2 @this) => @this.ContentEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatContentEndEvent? value)
        {
            ContentEnd = value;
        }

        /// <summary>
        /// A streamed event which contains a delta of tool plan text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolPlanDeltaEvent? ToolPlanDelta { get; init; }
#else
        public global::Cohere.ChatToolPlanDeltaEvent? ToolPlanDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolPlanDelta))]
#endif
        public bool IsToolPlanDelta => ToolPlanDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatToolPlanDeltaEvent value) => new StreamedChatResponseV2((global::Cohere.ChatToolPlanDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolPlanDeltaEvent?(StreamedChatResponseV2 @this) => @this.ToolPlanDelta;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatToolPlanDeltaEvent? value)
        {
            ToolPlanDelta = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a tool call has started streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallStartEvent? ToolCallStart { get; init; }
#else
        public global::Cohere.ChatToolCallStartEvent? ToolCallStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallStart))]
#endif
        public bool IsToolCallStart => ToolCallStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatToolCallStartEvent value) => new StreamedChatResponseV2((global::Cohere.ChatToolCallStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallStartEvent?(StreamedChatResponseV2 @this) => @this.ToolCallStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatToolCallStartEvent? value)
        {
            ToolCallStart = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a delta in tool call arguments.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallDeltaEvent? ToolCallDelta { get; init; }
#else
        public global::Cohere.ChatToolCallDeltaEvent? ToolCallDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallDelta))]
#endif
        public bool IsToolCallDelta => ToolCallDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatToolCallDeltaEvent value) => new StreamedChatResponseV2((global::Cohere.ChatToolCallDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallDeltaEvent?(StreamedChatResponseV2 @this) => @this.ToolCallDelta;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatToolCallDeltaEvent? value)
        {
            ToolCallDelta = value;
        }

        /// <summary>
        /// A streamed event delta which signifies a tool call has finished streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallEndEvent? ToolCallEnd { get; init; }
#else
        public global::Cohere.ChatToolCallEndEvent? ToolCallEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallEnd))]
#endif
        public bool IsToolCallEnd => ToolCallEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatToolCallEndEvent value) => new StreamedChatResponseV2((global::Cohere.ChatToolCallEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallEndEvent?(StreamedChatResponseV2 @this) => @this.ToolCallEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatToolCallEndEvent? value)
        {
            ToolCallEnd = value;
        }

        /// <summary>
        /// A streamed event which signifies that the chat message has ended.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatMessageEndEvent? MessageEnd { get; init; }
#else
        public global::Cohere.ChatMessageEndEvent? MessageEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageEnd))]
#endif
        public bool IsMessageEnd => MessageEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatMessageEndEvent value) => new StreamedChatResponseV2((global::Cohere.ChatMessageEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatMessageEndEvent?(StreamedChatResponseV2 @this) => @this.MessageEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatMessageEndEvent? value)
        {
            MessageEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatDebugEvent? Debug { get; init; }
#else
        public global::Cohere.ChatDebugEvent? Debug { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Debug))]
#endif
        public bool IsDebug => Debug != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponseV2(global::Cohere.ChatDebugEvent value) => new StreamedChatResponseV2((global::Cohere.ChatDebugEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatDebugEvent?(StreamedChatResponseV2 @this) => @this.Debug;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(global::Cohere.ChatDebugEvent? value)
        {
            Debug = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponseV2(
            global::Cohere.StreamedChatResponseV2DiscriminatorType? type,
            global::Cohere.ChatMessageStartEvent? messageStart,
            global::Cohere.ChatContentStartEvent? contentStart,
            global::Cohere.ChatContentDeltaEvent? contentDelta,
            global::Cohere.ChatContentEndEvent? contentEnd,
            global::Cohere.ChatToolPlanDeltaEvent? toolPlanDelta,
            global::Cohere.ChatToolCallStartEvent? toolCallStart,
            global::Cohere.ChatToolCallDeltaEvent? toolCallDelta,
            global::Cohere.ChatToolCallEndEvent? toolCallEnd,
            global::Cohere.ChatMessageEndEvent? messageEnd,
            global::Cohere.ChatDebugEvent? debug
            )
        {
            Type = type;

            MessageStart = messageStart;
            ContentStart = contentStart;
            ContentDelta = contentDelta;
            ContentEnd = contentEnd;
            ToolPlanDelta = toolPlanDelta;
            ToolCallStart = toolCallStart;
            ToolCallDelta = toolCallDelta;
            ToolCallEnd = toolCallEnd;
            MessageEnd = messageEnd;
            Debug = debug;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Debug as object ??
            MessageEnd as object ??
            ToolCallEnd as object ??
            ToolCallDelta as object ??
            ToolCallStart as object ??
            ToolPlanDelta as object ??
            ContentEnd as object ??
            ContentDelta as object ??
            ContentStart as object ??
            MessageStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageStart?.ToString() ??
            ContentStart?.ToString() ??
            ContentDelta?.ToString() ??
            ContentEnd?.ToString() ??
            ToolPlanDelta?.ToString() ??
            ToolCallStart?.ToString() ??
            ToolCallDelta?.ToString() ??
            ToolCallEnd?.ToString() ??
            MessageEnd?.ToString() ??
            Debug?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && IsToolCallEnd && !IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && IsMessageEnd && !IsDebug || !IsMessageStart && !IsContentStart && !IsContentDelta && !IsContentEnd && !IsToolPlanDelta && !IsToolCallStart && !IsToolCallDelta && !IsToolCallEnd && !IsMessageEnd && IsDebug;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatMessageStartEvent?, TResult>? messageStart = null,
            global::System.Func<global::Cohere.ChatContentStartEvent?, TResult>? contentStart = null,
            global::System.Func<global::Cohere.ChatContentDeltaEvent?, TResult>? contentDelta = null,
            global::System.Func<global::Cohere.ChatContentEndEvent?, TResult>? contentEnd = null,
            global::System.Func<global::Cohere.ChatToolPlanDeltaEvent?, TResult>? toolPlanDelta = null,
            global::System.Func<global::Cohere.ChatToolCallStartEvent?, TResult>? toolCallStart = null,
            global::System.Func<global::Cohere.ChatToolCallDeltaEvent?, TResult>? toolCallDelta = null,
            global::System.Func<global::Cohere.ChatToolCallEndEvent?, TResult>? toolCallEnd = null,
            global::System.Func<global::Cohere.ChatMessageEndEvent?, TResult>? messageEnd = null,
            global::System.Func<global::Cohere.ChatDebugEvent?, TResult>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart && messageStart != null)
            {
                return messageStart(MessageStart!);
            }
            else if (IsContentStart && contentStart != null)
            {
                return contentStart(ContentStart!);
            }
            else if (IsContentDelta && contentDelta != null)
            {
                return contentDelta(ContentDelta!);
            }
            else if (IsContentEnd && contentEnd != null)
            {
                return contentEnd(ContentEnd!);
            }
            else if (IsToolPlanDelta && toolPlanDelta != null)
            {
                return toolPlanDelta(ToolPlanDelta!);
            }
            else if (IsToolCallStart && toolCallStart != null)
            {
                return toolCallStart(ToolCallStart!);
            }
            else if (IsToolCallDelta && toolCallDelta != null)
            {
                return toolCallDelta(ToolCallDelta!);
            }
            else if (IsToolCallEnd && toolCallEnd != null)
            {
                return toolCallEnd(ToolCallEnd!);
            }
            else if (IsMessageEnd && messageEnd != null)
            {
                return messageEnd(MessageEnd!);
            }
            else if (IsDebug && debug != null)
            {
                return debug(Debug!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatMessageStartEvent?>? messageStart = null,
            global::System.Action<global::Cohere.ChatContentStartEvent?>? contentStart = null,
            global::System.Action<global::Cohere.ChatContentDeltaEvent?>? contentDelta = null,
            global::System.Action<global::Cohere.ChatContentEndEvent?>? contentEnd = null,
            global::System.Action<global::Cohere.ChatToolPlanDeltaEvent?>? toolPlanDelta = null,
            global::System.Action<global::Cohere.ChatToolCallStartEvent?>? toolCallStart = null,
            global::System.Action<global::Cohere.ChatToolCallDeltaEvent?>? toolCallDelta = null,
            global::System.Action<global::Cohere.ChatToolCallEndEvent?>? toolCallEnd = null,
            global::System.Action<global::Cohere.ChatMessageEndEvent?>? messageEnd = null,
            global::System.Action<global::Cohere.ChatDebugEvent?>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart)
            {
                messageStart?.Invoke(MessageStart!);
            }
            else if (IsContentStart)
            {
                contentStart?.Invoke(ContentStart!);
            }
            else if (IsContentDelta)
            {
                contentDelta?.Invoke(ContentDelta!);
            }
            else if (IsContentEnd)
            {
                contentEnd?.Invoke(ContentEnd!);
            }
            else if (IsToolPlanDelta)
            {
                toolPlanDelta?.Invoke(ToolPlanDelta!);
            }
            else if (IsToolCallStart)
            {
                toolCallStart?.Invoke(ToolCallStart!);
            }
            else if (IsToolCallDelta)
            {
                toolCallDelta?.Invoke(ToolCallDelta!);
            }
            else if (IsToolCallEnd)
            {
                toolCallEnd?.Invoke(ToolCallEnd!);
            }
            else if (IsMessageEnd)
            {
                messageEnd?.Invoke(MessageEnd!);
            }
            else if (IsDebug)
            {
                debug?.Invoke(Debug!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStart,
                typeof(global::Cohere.ChatMessageStartEvent),
                ContentStart,
                typeof(global::Cohere.ChatContentStartEvent),
                ContentDelta,
                typeof(global::Cohere.ChatContentDeltaEvent),
                ContentEnd,
                typeof(global::Cohere.ChatContentEndEvent),
                ToolPlanDelta,
                typeof(global::Cohere.ChatToolPlanDeltaEvent),
                ToolCallStart,
                typeof(global::Cohere.ChatToolCallStartEvent),
                ToolCallDelta,
                typeof(global::Cohere.ChatToolCallDeltaEvent),
                ToolCallEnd,
                typeof(global::Cohere.ChatToolCallEndEvent),
                MessageEnd,
                typeof(global::Cohere.ChatMessageEndEvent),
                Debug,
                typeof(global::Cohere.ChatDebugEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatMessageStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatContentStartEvent?>.Default.Equals(ContentStart, other.ContentStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatContentDeltaEvent?>.Default.Equals(ContentDelta, other.ContentDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatContentEndEvent?>.Default.Equals(ContentEnd, other.ContentEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolPlanDeltaEvent?>.Default.Equals(ToolPlanDelta, other.ToolPlanDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallStartEvent?>.Default.Equals(ToolCallStart, other.ToolCallStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallDeltaEvent?>.Default.Equals(ToolCallDelta, other.ToolCallDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallEndEvent?>.Default.Equals(ToolCallEnd, other.ToolCallEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatMessageEndEvent?>.Default.Equals(MessageEnd, other.MessageEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatDebugEvent?>.Default.Equals(Debug, other.Debug) 
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
