using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// StreamedChatResponse is returned in streaming mode (specified with `stream=True` in the request).
    /// </summary>
    public readonly partial struct StreamedChatResponse : global::System.IEquatable<StreamedChatResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamStartEvent? StreamStartEvent { get; init; }
#else
        public global::Cohere.ChatStreamStartEvent? StreamStartEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamStartEvent))]
#endif
        public bool IsStreamStartEvent => StreamStartEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatStreamStartEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamStartEvent?(StreamedChatResponse @this) => @this.StreamStartEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatStreamStartEvent? value)
        {
            StreamStartEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatSearchQueriesGenerationEvent? SearchQueriesGenerationEvent { get; init; }
#else
        public global::Cohere.ChatSearchQueriesGenerationEvent? SearchQueriesGenerationEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchQueriesGenerationEvent))]
#endif
        public bool IsSearchQueriesGenerationEvent => SearchQueriesGenerationEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatSearchQueriesGenerationEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatSearchQueriesGenerationEvent?(StreamedChatResponse @this) => @this.SearchQueriesGenerationEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatSearchQueriesGenerationEvent? value)
        {
            SearchQueriesGenerationEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatSearchResultsEvent? SearchResultsEvent { get; init; }
#else
        public global::Cohere.ChatSearchResultsEvent? SearchResultsEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResultsEvent))]
#endif
        public bool IsSearchResultsEvent => SearchResultsEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatSearchResultsEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatSearchResultsEvent?(StreamedChatResponse @this) => @this.SearchResultsEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatSearchResultsEvent? value)
        {
            SearchResultsEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatTextGenerationEvent? TextGenerationEvent { get; init; }
#else
        public global::Cohere.ChatTextGenerationEvent? TextGenerationEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGenerationEvent))]
#endif
        public bool IsTextGenerationEvent => TextGenerationEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatTextGenerationEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatTextGenerationEvent?(StreamedChatResponse @this) => @this.TextGenerationEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatTextGenerationEvent? value)
        {
            TextGenerationEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatCitationGenerationEvent? CitationGenerationEvent { get; init; }
#else
        public global::Cohere.ChatCitationGenerationEvent? CitationGenerationEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CitationGenerationEvent))]
#endif
        public bool IsCitationGenerationEvent => CitationGenerationEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatCitationGenerationEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatCitationGenerationEvent?(StreamedChatResponse @this) => @this.CitationGenerationEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatCitationGenerationEvent? value)
        {
            CitationGenerationEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallsGenerationEvent? ToolCallsGenerationEvent { get; init; }
#else
        public global::Cohere.ChatToolCallsGenerationEvent? ToolCallsGenerationEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallsGenerationEvent))]
#endif
        public bool IsToolCallsGenerationEvent => ToolCallsGenerationEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatToolCallsGenerationEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallsGenerationEvent?(StreamedChatResponse @this) => @this.ToolCallsGenerationEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatToolCallsGenerationEvent? value)
        {
            ToolCallsGenerationEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamEndEvent? StreamEndEvent { get; init; }
#else
        public global::Cohere.ChatStreamEndEvent? StreamEndEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEndEvent))]
#endif
        public bool IsStreamEndEvent => StreamEndEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatStreamEndEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEndEvent?(StreamedChatResponse @this) => @this.StreamEndEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatStreamEndEvent? value)
        {
            StreamEndEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallsChunkEvent? ToolCallsChunkEvent { get; init; }
#else
        public global::Cohere.ChatToolCallsChunkEvent? ToolCallsChunkEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallsChunkEvent))]
#endif
        public bool IsToolCallsChunkEvent => ToolCallsChunkEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatToolCallsChunkEvent value) => new StreamedChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallsChunkEvent?(StreamedChatResponse @this) => @this.ToolCallsChunkEvent;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatToolCallsChunkEvent? value)
        {
            ToolCallsChunkEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(
            global::Cohere.ChatStreamStartEvent? streamStartEvent,
            global::Cohere.ChatSearchQueriesGenerationEvent? searchQueriesGenerationEvent,
            global::Cohere.ChatSearchResultsEvent? searchResultsEvent,
            global::Cohere.ChatTextGenerationEvent? textGenerationEvent,
            global::Cohere.ChatCitationGenerationEvent? citationGenerationEvent,
            global::Cohere.ChatToolCallsGenerationEvent? toolCallsGenerationEvent,
            global::Cohere.ChatStreamEndEvent? streamEndEvent,
            global::Cohere.ChatToolCallsChunkEvent? toolCallsChunkEvent
            )
        {
            StreamStartEvent = streamStartEvent;
            SearchQueriesGenerationEvent = searchQueriesGenerationEvent;
            SearchResultsEvent = searchResultsEvent;
            TextGenerationEvent = textGenerationEvent;
            CitationGenerationEvent = citationGenerationEvent;
            ToolCallsGenerationEvent = toolCallsGenerationEvent;
            StreamEndEvent = streamEndEvent;
            ToolCallsChunkEvent = toolCallsChunkEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolCallsChunkEvent as object ??
            StreamEndEvent as object ??
            ToolCallsGenerationEvent as object ??
            CitationGenerationEvent as object ??
            TextGenerationEvent as object ??
            SearchResultsEvent as object ??
            SearchQueriesGenerationEvent as object ??
            StreamStartEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && IsToolCallsGenerationEvent && !IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && IsStreamEndEvent && !IsToolCallsChunkEvent || !IsStreamStartEvent && !IsSearchQueriesGenerationEvent && !IsSearchResultsEvent && !IsTextGenerationEvent && !IsCitationGenerationEvent && !IsToolCallsGenerationEvent && !IsStreamEndEvent && IsToolCallsChunkEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatStreamStartEvent?, TResult>? streamStartEvent = null,
            global::System.Func<global::Cohere.ChatSearchQueriesGenerationEvent?, TResult>? searchQueriesGenerationEvent = null,
            global::System.Func<global::Cohere.ChatSearchResultsEvent?, TResult>? searchResultsEvent = null,
            global::System.Func<global::Cohere.ChatTextGenerationEvent?, TResult>? textGenerationEvent = null,
            global::System.Func<global::Cohere.ChatCitationGenerationEvent?, TResult>? citationGenerationEvent = null,
            global::System.Func<global::Cohere.ChatToolCallsGenerationEvent?, TResult>? toolCallsGenerationEvent = null,
            global::System.Func<global::Cohere.ChatStreamEndEvent?, TResult>? streamEndEvent = null,
            global::System.Func<global::Cohere.ChatToolCallsChunkEvent?, TResult>? toolCallsChunkEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStartEvent && streamStartEvent != null)
            {
                return streamStartEvent(StreamStartEvent!);
            }
            else if (IsSearchQueriesGenerationEvent && searchQueriesGenerationEvent != null)
            {
                return searchQueriesGenerationEvent(SearchQueriesGenerationEvent!);
            }
            else if (IsSearchResultsEvent && searchResultsEvent != null)
            {
                return searchResultsEvent(SearchResultsEvent!);
            }
            else if (IsTextGenerationEvent && textGenerationEvent != null)
            {
                return textGenerationEvent(TextGenerationEvent!);
            }
            else if (IsCitationGenerationEvent && citationGenerationEvent != null)
            {
                return citationGenerationEvent(CitationGenerationEvent!);
            }
            else if (IsToolCallsGenerationEvent && toolCallsGenerationEvent != null)
            {
                return toolCallsGenerationEvent(ToolCallsGenerationEvent!);
            }
            else if (IsStreamEndEvent && streamEndEvent != null)
            {
                return streamEndEvent(StreamEndEvent!);
            }
            else if (IsToolCallsChunkEvent && toolCallsChunkEvent != null)
            {
                return toolCallsChunkEvent(ToolCallsChunkEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.ChatStreamStartEvent?>? streamStartEvent = null,
            global::System.Action<global::Cohere.ChatSearchQueriesGenerationEvent?>? searchQueriesGenerationEvent = null,
            global::System.Action<global::Cohere.ChatSearchResultsEvent?>? searchResultsEvent = null,
            global::System.Action<global::Cohere.ChatTextGenerationEvent?>? textGenerationEvent = null,
            global::System.Action<global::Cohere.ChatCitationGenerationEvent?>? citationGenerationEvent = null,
            global::System.Action<global::Cohere.ChatToolCallsGenerationEvent?>? toolCallsGenerationEvent = null,
            global::System.Action<global::Cohere.ChatStreamEndEvent?>? streamEndEvent = null,
            global::System.Action<global::Cohere.ChatToolCallsChunkEvent?>? toolCallsChunkEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStartEvent)
            {
                streamStartEvent?.Invoke(StreamStartEvent!);
            }
            else if (IsSearchQueriesGenerationEvent)
            {
                searchQueriesGenerationEvent?.Invoke(SearchQueriesGenerationEvent!);
            }
            else if (IsSearchResultsEvent)
            {
                searchResultsEvent?.Invoke(SearchResultsEvent!);
            }
            else if (IsTextGenerationEvent)
            {
                textGenerationEvent?.Invoke(TextGenerationEvent!);
            }
            else if (IsCitationGenerationEvent)
            {
                citationGenerationEvent?.Invoke(CitationGenerationEvent!);
            }
            else if (IsToolCallsGenerationEvent)
            {
                toolCallsGenerationEvent?.Invoke(ToolCallsGenerationEvent!);
            }
            else if (IsStreamEndEvent)
            {
                streamEndEvent?.Invoke(StreamEndEvent!);
            }
            else if (IsToolCallsChunkEvent)
            {
                toolCallsChunkEvent?.Invoke(ToolCallsChunkEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamStartEvent,
                typeof(global::Cohere.ChatStreamStartEvent),
                SearchQueriesGenerationEvent,
                typeof(global::Cohere.ChatSearchQueriesGenerationEvent),
                SearchResultsEvent,
                typeof(global::Cohere.ChatSearchResultsEvent),
                TextGenerationEvent,
                typeof(global::Cohere.ChatTextGenerationEvent),
                CitationGenerationEvent,
                typeof(global::Cohere.ChatCitationGenerationEvent),
                ToolCallsGenerationEvent,
                typeof(global::Cohere.ChatToolCallsGenerationEvent),
                StreamEndEvent,
                typeof(global::Cohere.ChatStreamEndEvent),
                ToolCallsChunkEvent,
                typeof(global::Cohere.ChatToolCallsChunkEvent),
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
        public bool Equals(StreamedChatResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamStartEvent?>.Default.Equals(StreamStartEvent, other.StreamStartEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatSearchQueriesGenerationEvent?>.Default.Equals(SearchQueriesGenerationEvent, other.SearchQueriesGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatSearchResultsEvent?>.Default.Equals(SearchResultsEvent, other.SearchResultsEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatTextGenerationEvent?>.Default.Equals(TextGenerationEvent, other.TextGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatCitationGenerationEvent?>.Default.Equals(CitationGenerationEvent, other.CitationGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallsGenerationEvent?>.Default.Equals(ToolCallsGenerationEvent, other.ToolCallsGenerationEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEndEvent?>.Default.Equals(StreamEndEvent, other.StreamEndEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallsChunkEvent?>.Default.Equals(ToolCallsChunkEvent, other.ToolCallsChunkEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamedChatResponse obj1, StreamedChatResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamedChatResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamedChatResponse obj1, StreamedChatResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamedChatResponse o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Cohere.StreamedChatResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Cohere.StreamedChatResponse),
                jsonSerializerContext) as global::Cohere.StreamedChatResponse?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Cohere.StreamedChatResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Cohere.StreamedChatResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
