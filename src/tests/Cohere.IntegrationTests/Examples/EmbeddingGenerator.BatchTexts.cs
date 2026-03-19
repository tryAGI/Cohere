/*
order: 80
title: Embedding Generator Batch Texts
slug: embedding-generator-batch-texts
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_BatchTexts()
    {
        using var client = GetAuthenticatedCohereClient();

        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;
        var embeddings = await generator.GenerateAsync(
            ["Hello", "World", "Test"],
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "embed-english-v3.0",
            });

        embeddings.Should().HaveCount(3);
        foreach (var embedding in embeddings)
        {
            embedding.Vector.Length.Should().BeGreaterThan(0);
        }
    }
}
