#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbedResponse : global::System.IEquatable<EmbedResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cohere.EmbedResponseDiscriminatorResponseType? ResponseType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.EmbedFloatsResponse? EmbeddingsFloats { get; init; }
#else
        public global::Cohere.EmbedFloatsResponse? EmbeddingsFloats { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsFloats))]
#endif
        public bool IsEmbeddingsFloats => EmbeddingsFloats != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbedResponse(global::Cohere.EmbedFloatsResponse value) => new EmbedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.EmbedFloatsResponse?(EmbedResponse @this) => @this.EmbeddingsFloats;

        /// <summary>
        /// 
        /// </summary>
        public EmbedResponse(global::Cohere.EmbedFloatsResponse? value)
        {
            EmbeddingsFloats = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cohere.EmbedByTypeResponse? EmbeddingsByType { get; init; }
#else
        public global::Cohere.EmbedByTypeResponse? EmbeddingsByType { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsByType))]
#endif
        public bool IsEmbeddingsByType => EmbeddingsByType != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbedResponse(global::Cohere.EmbedByTypeResponse value) => new EmbedResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cohere.EmbedByTypeResponse?(EmbedResponse @this) => @this.EmbeddingsByType;

        /// <summary>
        /// 
        /// </summary>
        public EmbedResponse(global::Cohere.EmbedByTypeResponse? value)
        {
            EmbeddingsByType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbedResponse(
            global::Cohere.EmbedResponseDiscriminatorResponseType? responseType,
            global::Cohere.EmbedFloatsResponse? embeddingsFloats,
            global::Cohere.EmbedByTypeResponse? embeddingsByType
            )
        {
            ResponseType = responseType;

            EmbeddingsFloats = embeddingsFloats;
            EmbeddingsByType = embeddingsByType;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsByType as object ??
            EmbeddingsFloats as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingsFloats && !IsEmbeddingsByType || !IsEmbeddingsFloats && IsEmbeddingsByType;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cohere.EmbedFloatsResponse?, TResult>? embeddingsFloats = null,
            global::System.Func<global::Cohere.EmbedByTypeResponse?, TResult>? embeddingsByType = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsFloats && embeddingsFloats != null)
            {
                return embeddingsFloats(EmbeddingsFloats!);
            }
            else if (IsEmbeddingsByType && embeddingsByType != null)
            {
                return embeddingsByType(EmbeddingsByType!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cohere.EmbedFloatsResponse?>? embeddingsFloats = null,
            global::System.Action<global::Cohere.EmbedByTypeResponse?>? embeddingsByType = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingsFloats)
            {
                embeddingsFloats?.Invoke(EmbeddingsFloats!);
            }
            else if (IsEmbeddingsByType)
            {
                embeddingsByType?.Invoke(EmbeddingsByType!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingsFloats,
                typeof(global::Cohere.EmbedFloatsResponse),
                EmbeddingsByType,
                typeof(global::Cohere.EmbedByTypeResponse),
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
        public bool Equals(EmbedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cohere.EmbedFloatsResponse?>.Default.Equals(EmbeddingsFloats, other.EmbeddingsFloats) &&
                global::System.Collections.Generic.EqualityComparer<global::Cohere.EmbedByTypeResponse?>.Default.Equals(EmbeddingsByType, other.EmbeddingsByType) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbedResponse obj1, EmbedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbedResponse obj1, EmbedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbedResponse o && Equals(o);
        }
    }
}
