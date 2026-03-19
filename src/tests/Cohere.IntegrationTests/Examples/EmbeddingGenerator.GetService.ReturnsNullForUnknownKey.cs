/*
order: 100
title: Embedding Generator Get Service Returns Null For Unknown Key
slug: embedding-generator-get-service-returns-null-for-unknown-key
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsNullForUnknownKey()
    {
        using var client = CreateTestClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var result = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator, serviceKey: "unknown");

        result.Should().BeNull();
    }
}
