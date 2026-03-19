/*
order: 90
title: Embedding Generator Get Service Returns Metadata
slug: embedding-generator-get-service-returns-metadata
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsMetadata()
    {
        using var client = CreateTestClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var metadata = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator);

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(CohereClient));
    }
}
