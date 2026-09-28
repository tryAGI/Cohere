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
        public bool TryPickStreamStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatStreamStartEvent? value)
        {
            value = StreamStart;
            return IsStreamStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamStartEvent PickStreamStart() => StreamStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamStart' but the value was {ToString()}.");

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
        public bool TryPickSearchQueriesGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatSearchQueriesGenerationEvent? value)
        {
            value = SearchQueriesGeneration;
            return IsSearchQueriesGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchQueriesGenerationEvent PickSearchQueriesGeneration() => SearchQueriesGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchQueriesGeneration' but the value was {ToString()}.");

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
        public bool TryPickSearchResults(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatSearchResultsEvent? value)
        {
            value = SearchResults;
            return IsSearchResults;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatSearchResultsEvent PickSearchResults() => SearchResults is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResults' but the value was {ToString()}.");

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
        public bool TryPickTextGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatTextGenerationEvent? value)
        {
            value = TextGeneration;
            return IsTextGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatTextGenerationEvent PickTextGeneration() => TextGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextGeneration' but the value was {ToString()}.");

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
        public bool TryPickCitationGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatCitationGenerationEvent? value)
        {
            value = CitationGeneration;
            return IsCitationGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatCitationGenerationEvent PickCitationGeneration() => CitationGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CitationGeneration' but the value was {ToString()}.");

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
        public bool TryPickToolCallsGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatToolCallsGenerationEvent? value)
        {
            value = ToolCallsGeneration;
            return IsToolCallsGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallsGenerationEvent PickToolCallsGeneration() => ToolCallsGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCallsGeneration' but the value was {ToString()}.");

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
        public bool TryPickStreamEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatStreamEndEvent? value)
        {
            value = StreamEnd;
            return IsStreamEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatStreamEndEvent PickStreamEnd() => StreamEnd is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEnd' but the value was {ToString()}.");

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
        public bool TryPickToolCallsChunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatToolCallsChunkEvent? value)
        {
            value = ToolCallsChunk;
            return IsToolCallsChunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatToolCallsChunkEvent PickToolCallsChunk() => ToolCallsChunk is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCallsChunk' but the value was {ToString()}.");

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
        public bool TryPickDebug(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cohere.ChatDebugEvent? value)
        {
            value = Debug;
            return IsDebug;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cohere.ChatDebugEvent PickDebug() => Debug is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Debug' but the value was {ToString()}.");
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
        public static StreamedChatResponse FromStreamStart(global::Cohere.ChatStreamStartEvent? value) => new StreamedChatResponse(value);

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
        public static StreamedChatResponse FromSearchQueriesGeneration(global::Cohere.ChatSearchQueriesGenerationEvent? value) => new StreamedChatResponse(value);

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
        public static StreamedChatResponse FromSearchResults(global::Cohere.ChatSearchResultsEvent? value) => new StreamedChatResponse(value);

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
        public static StreamedChatResponse FromTextGeneration(global::Cohere.ChatTextGenerationEvent? value) => new StreamedChatResponse(value);

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
        public static StreamedChatResponse FromCitationGeneration(global::Cohere.ChatCitationGenerationEvent? value) => new StreamedChatResponse(value);

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
        public static StreamedChatResponse FromToolCallsGeneration(global::Cohere.ChatToolCallsGenerationEvent? value) => new StreamedChatResponse(value);

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
        public static StreamedChatResponse FromStreamEnd(global::Cohere.ChatStreamEndEvent? value) => new StreamedChatResponse(value);

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
        public static StreamedChatResponse FromToolCallsChunk(global::Cohere.ChatToolCallsChunkEvent? value) => new StreamedChatResponse(value);

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
        public static StreamedChatResponse FromDebug(global::Cohere.ChatDebugEvent? value) => new StreamedChatResponse(value);

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

            if (StreamStart is { } __value0 && streamStart != null)
            {
                return streamStart(__value0);
            }
            else if (SearchQueriesGeneration is { } __value1 && searchQueriesGeneration != null)
            {
                return searchQueriesGeneration(__value1);
            }
            else if (SearchResults is { } __value2 && searchResults != null)
            {
                return searchResults(__value2);
            }
            else if (TextGeneration is { } __value3 && textGeneration != null)
            {
                return textGeneration(__value3);
            }
            else if (CitationGeneration is { } __value4 && citationGeneration != null)
            {
                return citationGeneration(__value4);
            }
            else if (ToolCallsGeneration is { } __value5 && toolCallsGeneration != null)
            {
                return toolCallsGeneration(__value5);
            }
            else if (StreamEnd is { } __value6 && streamEnd != null)
            {
                return streamEnd(__value6);
            }
            else if (ToolCallsChunk is { } __value7 && toolCallsChunk != null)
            {
                return toolCallsChunk(__value7);
            }
            else if (Debug is { } __value8 && debug != null)
            {
                return debug(__value8);
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

            if (StreamStart is { } __value0)
            {
                streamStart?.Invoke(__value0);
            }
            else if (SearchQueriesGeneration is { } __value1)
            {
                searchQueriesGeneration?.Invoke(__value1);
            }
            else if (SearchResults is { } __value2)
            {
                searchResults?.Invoke(__value2);
            }
            else if (TextGeneration is { } __value3)
            {
                textGeneration?.Invoke(__value3);
            }
            else if (CitationGeneration is { } __value4)
            {
                citationGeneration?.Invoke(__value4);
            }
            else if (ToolCallsGeneration is { } __value5)
            {
                toolCallsGeneration?.Invoke(__value5);
            }
            else if (StreamEnd is { } __value6)
            {
                streamEnd?.Invoke(__value6);
            }
            else if (ToolCallsChunk is { } __value7)
            {
                toolCallsChunk?.Invoke(__value7);
            }
            else if (Debug is { } __value8)
            {
                debug?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
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

            if (StreamStart is { } __value0)
            {
                streamStart?.Invoke(__value0);
            }
            else if (SearchQueriesGeneration is { } __value1)
            {
                searchQueriesGeneration?.Invoke(__value1);
            }
            else if (SearchResults is { } __value2)
            {
                searchResults?.Invoke(__value2);
            }
            else if (TextGeneration is { } __value3)
            {
                textGeneration?.Invoke(__value3);
            }
            else if (CitationGeneration is { } __value4)
            {
                citationGeneration?.Invoke(__value4);
            }
            else if (ToolCallsGeneration is { } __value5)
            {
                toolCallsGeneration?.Invoke(__value5);
            }
            else if (StreamEnd is { } __value6)
            {
                streamEnd?.Invoke(__value6);
            }
            else if (ToolCallsChunk is { } __value7)
            {
                toolCallsChunk?.Invoke(__value7);
            }
            else if (Debug is { } __value8)
            {
                debug?.Invoke(__value8);
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
