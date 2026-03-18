using Meai = Microsoft.Extensions.AI;

namespace Cohere;

public partial class CohereClient : Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>
{
    private Meai.EmbeddingGeneratorMetadata? _embeddingMetadata;

    object? Meai.IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.EmbeddingGeneratorMetadata) ? (_embeddingMetadata ??= new(nameof(CohereClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<Meai.GeneratedEmbeddings<Meai.Embedding<float>>> Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>.GenerateAsync(
        IEnumerable<string> values,
        Meai.EmbeddingGenerationOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(values);

        var texts = values as IList<string> ?? values.ToList();

        var request = new Embedv2Request
        {
            Model = options?.ModelId ?? "embed-english-v3.0",
            Texts = texts,
            InputType = EmbedInputType.SearchDocument,
            EmbeddingTypes = [EmbeddingType.Float],
            Truncate = Embedv2RequestTruncate.End,
        };

        var response = await Embedv2Async(request, cancellationToken: cancellationToken).ConfigureAwait(false);

        var embeddings = new Meai.GeneratedEmbeddings<Meai.Embedding<float>>();

        if (response.Embeddings.Float is { } floatEmbeddings)
        {
            foreach (var embedding in floatEmbeddings)
            {
                var floatArray = new float[embedding.Count];
                for (var i = 0; i < embedding.Count; i++)
                {
                    floatArray[i] = (float)embedding[i];
                }

                embeddings.Add(new Meai.Embedding<float>(floatArray)
                {
                    ModelId = options?.ModelId,
                });
            }
        }

        return embeddings;
    }
}
