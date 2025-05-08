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
        public global::Cohere.StreamedChatResponseDiscriminatorEventType? EventType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamStartEvent? StreamStart { get; init; }
#else
        public global::Cohere.ChatStreamStartEvent? StreamStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamStart))]
#endif
        public bool IsStreamStart => StreamStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatStreamStartEvent value) => new StreamedChatResponse((global::Cohere.ChatStreamStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamStartEvent?(StreamedChatResponse @this) => @this.StreamStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatStreamStartEvent? value)
        {
            StreamStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatSearchQueriesGenerationEvent? SearchQueriesGeneration { get; init; }
#else
        public global::Cohere.ChatSearchQueriesGenerationEvent? SearchQueriesGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchQueriesGeneration))]
#endif
        public bool IsSearchQueriesGeneration => SearchQueriesGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatSearchQueriesGenerationEvent value) => new StreamedChatResponse((global::Cohere.ChatSearchQueriesGenerationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatSearchQueriesGenerationEvent?(StreamedChatResponse @this) => @this.SearchQueriesGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatSearchQueriesGenerationEvent? value)
        {
            SearchQueriesGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatSearchResultsEvent? SearchResults { get; init; }
#else
        public global::Cohere.ChatSearchResultsEvent? SearchResults { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResults))]
#endif
        public bool IsSearchResults => SearchResults != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatSearchResultsEvent value) => new StreamedChatResponse((global::Cohere.ChatSearchResultsEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatSearchResultsEvent?(StreamedChatResponse @this) => @this.SearchResults;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatSearchResultsEvent? value)
        {
            SearchResults = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatTextGenerationEvent? TextGeneration { get; init; }
#else
        public global::Cohere.ChatTextGenerationEvent? TextGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGeneration))]
#endif
        public bool IsTextGeneration => TextGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatTextGenerationEvent value) => new StreamedChatResponse((global::Cohere.ChatTextGenerationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatTextGenerationEvent?(StreamedChatResponse @this) => @this.TextGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatTextGenerationEvent? value)
        {
            TextGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatCitationGenerationEvent? CitationGeneration { get; init; }
#else
        public global::Cohere.ChatCitationGenerationEvent? CitationGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CitationGeneration))]
#endif
        public bool IsCitationGeneration => CitationGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatCitationGenerationEvent value) => new StreamedChatResponse((global::Cohere.ChatCitationGenerationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatCitationGenerationEvent?(StreamedChatResponse @this) => @this.CitationGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatCitationGenerationEvent? value)
        {
            CitationGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallsGenerationEvent? ToolCallsGeneration { get; init; }
#else
        public global::Cohere.ChatToolCallsGenerationEvent? ToolCallsGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallsGeneration))]
#endif
        public bool IsToolCallsGeneration => ToolCallsGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatToolCallsGenerationEvent value) => new StreamedChatResponse((global::Cohere.ChatToolCallsGenerationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallsGenerationEvent?(StreamedChatResponse @this) => @this.ToolCallsGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatToolCallsGenerationEvent? value)
        {
            ToolCallsGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatStreamEndEvent? StreamEnd { get; init; }
#else
        public global::Cohere.ChatStreamEndEvent? StreamEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEnd))]
#endif
        public bool IsStreamEnd => StreamEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatStreamEndEvent value) => new StreamedChatResponse((global::Cohere.ChatStreamEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatStreamEndEvent?(StreamedChatResponse @this) => @this.StreamEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatStreamEndEvent? value)
        {
            StreamEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.ChatToolCallsChunkEvent? ToolCallsChunk { get; init; }
#else
        public global::Cohere.ChatToolCallsChunkEvent? ToolCallsChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallsChunk))]
#endif
        public bool IsToolCallsChunk => ToolCallsChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamedChatResponse(global::Cohere.ChatToolCallsChunkEvent value) => new StreamedChatResponse((global::Cohere.ChatToolCallsChunkEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatToolCallsChunkEvent?(StreamedChatResponse @this) => @this.ToolCallsChunk;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatToolCallsChunkEvent? value)
        {
            ToolCallsChunk = value;
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
        public static implicit operator StreamedChatResponse(global::Cohere.ChatDebugEvent value) => new StreamedChatResponse((global::Cohere.ChatDebugEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.ChatDebugEvent?(StreamedChatResponse @this) => @this.Debug;

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(global::Cohere.ChatDebugEvent? value)
        {
            Debug = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamedChatResponse(
            global::Cohere.StreamedChatResponseDiscriminatorEventType? eventType,
            global::Cohere.ChatStreamStartEvent? streamStart,
            global::Cohere.ChatSearchQueriesGenerationEvent? searchQueriesGeneration,
            global::Cohere.ChatSearchResultsEvent? searchResults,
            global::Cohere.ChatTextGenerationEvent? textGeneration,
            global::Cohere.ChatCitationGenerationEvent? citationGeneration,
            global::Cohere.ChatToolCallsGenerationEvent? toolCallsGeneration,
            global::Cohere.ChatStreamEndEvent? streamEnd,
            global::Cohere.ChatToolCallsChunkEvent? toolCallsChunk,
            global::Cohere.ChatDebugEvent? debug
            )
        {
            EventType = eventType;

            StreamStart = streamStart;
            SearchQueriesGeneration = searchQueriesGeneration;
            SearchResults = searchResults;
            TextGeneration = textGeneration;
            CitationGeneration = citationGeneration;
            ToolCallsGeneration = toolCallsGeneration;
            StreamEnd = streamEnd;
            ToolCallsChunk = toolCallsChunk;
            Debug = debug;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Debug as object ??
            ToolCallsChunk as object ??
            StreamEnd as object ??
            ToolCallsGeneration as object ??
            CitationGeneration as object ??
            TextGeneration as object ??
            SearchResults as object ??
            SearchQueriesGeneration as object ??
            StreamStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamStart?.ToString() ??
            SearchQueriesGeneration?.ToString() ??
            SearchResults?.ToString() ??
            TextGeneration?.ToString() ??
            CitationGeneration?.ToString() ??
            ToolCallsGeneration?.ToString() ??
            StreamEnd?.ToString() ??
            ToolCallsChunk?.ToString() ??
            Debug?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && IsStreamEnd && !IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && IsToolCallsChunk && !IsDebug || !IsStreamStart && !IsSearchQueriesGeneration && !IsSearchResults && !IsTextGeneration && !IsCitationGeneration && !IsToolCallsGeneration && !IsStreamEnd && !IsToolCallsChunk && IsDebug;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.ChatStreamStartEvent?, TResult>? streamStart = null,
            global::System.Func<global::Cohere.ChatSearchQueriesGenerationEvent?, TResult>? searchQueriesGeneration = null,
            global::System.Func<global::Cohere.ChatSearchResultsEvent?, TResult>? searchResults = null,
            global::System.Func<global::Cohere.ChatTextGenerationEvent?, TResult>? textGeneration = null,
            global::System.Func<global::Cohere.ChatCitationGenerationEvent?, TResult>? citationGeneration = null,
            global::System.Func<global::Cohere.ChatToolCallsGenerationEvent?, TResult>? toolCallsGeneration = null,
            global::System.Func<global::Cohere.ChatStreamEndEvent?, TResult>? streamEnd = null,
            global::System.Func<global::Cohere.ChatToolCallsChunkEvent?, TResult>? toolCallsChunk = null,
            global::System.Func<global::Cohere.ChatDebugEvent?, TResult>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStart && streamStart != null)
            {
                return streamStart(StreamStart!);
            }
            else if (IsSearchQueriesGeneration && searchQueriesGeneration != null)
            {
                return searchQueriesGeneration(SearchQueriesGeneration!);
            }
            else if (IsSearchResults && searchResults != null)
            {
                return searchResults(SearchResults!);
            }
            else if (IsTextGeneration && textGeneration != null)
            {
                return textGeneration(TextGeneration!);
            }
            else if (IsCitationGeneration && citationGeneration != null)
            {
                return citationGeneration(CitationGeneration!);
            }
            else if (IsToolCallsGeneration && toolCallsGeneration != null)
            {
                return toolCallsGeneration(ToolCallsGeneration!);
            }
            else if (IsStreamEnd && streamEnd != null)
            {
                return streamEnd(StreamEnd!);
            }
            else if (IsToolCallsChunk && toolCallsChunk != null)
            {
                return toolCallsChunk(ToolCallsChunk!);
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
            global::System.Action<global::Cohere.ChatStreamStartEvent?>? streamStart = null,
            global::System.Action<global::Cohere.ChatSearchQueriesGenerationEvent?>? searchQueriesGeneration = null,
            global::System.Action<global::Cohere.ChatSearchResultsEvent?>? searchResults = null,
            global::System.Action<global::Cohere.ChatTextGenerationEvent?>? textGeneration = null,
            global::System.Action<global::Cohere.ChatCitationGenerationEvent?>? citationGeneration = null,
            global::System.Action<global::Cohere.ChatToolCallsGenerationEvent?>? toolCallsGeneration = null,
            global::System.Action<global::Cohere.ChatStreamEndEvent?>? streamEnd = null,
            global::System.Action<global::Cohere.ChatToolCallsChunkEvent?>? toolCallsChunk = null,
            global::System.Action<global::Cohere.ChatDebugEvent?>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStart)
            {
                streamStart?.Invoke(StreamStart!);
            }
            else if (IsSearchQueriesGeneration)
            {
                searchQueriesGeneration?.Invoke(SearchQueriesGeneration!);
            }
            else if (IsSearchResults)
            {
                searchResults?.Invoke(SearchResults!);
            }
            else if (IsTextGeneration)
            {
                textGeneration?.Invoke(TextGeneration!);
            }
            else if (IsCitationGeneration)
            {
                citationGeneration?.Invoke(CitationGeneration!);
            }
            else if (IsToolCallsGeneration)
            {
                toolCallsGeneration?.Invoke(ToolCallsGeneration!);
            }
            else if (IsStreamEnd)
            {
                streamEnd?.Invoke(StreamEnd!);
            }
            else if (IsToolCallsChunk)
            {
                toolCallsChunk?.Invoke(ToolCallsChunk!);
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
                StreamStart,
                typeof(global::Cohere.ChatStreamStartEvent),
                SearchQueriesGeneration,
                typeof(global::Cohere.ChatSearchQueriesGenerationEvent),
                SearchResults,
                typeof(global::Cohere.ChatSearchResultsEvent),
                TextGeneration,
                typeof(global::Cohere.ChatTextGenerationEvent),
                CitationGeneration,
                typeof(global::Cohere.ChatCitationGenerationEvent),
                ToolCallsGeneration,
                typeof(global::Cohere.ChatToolCallsGenerationEvent),
                StreamEnd,
                typeof(global::Cohere.ChatStreamEndEvent),
                ToolCallsChunk,
                typeof(global::Cohere.ChatToolCallsChunkEvent),
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
        public bool Equals(StreamedChatResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamStartEvent?>.Default.Equals(StreamStart, other.StreamStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatSearchQueriesGenerationEvent?>.Default.Equals(SearchQueriesGeneration, other.SearchQueriesGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatSearchResultsEvent?>.Default.Equals(SearchResults, other.SearchResults) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatTextGenerationEvent?>.Default.Equals(TextGeneration, other.TextGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatCitationGenerationEvent?>.Default.Equals(CitationGeneration, other.CitationGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallsGenerationEvent?>.Default.Equals(ToolCallsGeneration, other.ToolCallsGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatStreamEndEvent?>.Default.Equals(StreamEnd, other.StreamEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatToolCallsChunkEvent?>.Default.Equals(ToolCallsChunk, other.ToolCallsChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.ChatDebugEvent?>.Default.Equals(Debug, other.Debug) 
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
    }
}
