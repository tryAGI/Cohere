/*
order: 110
title: Embedding Generator Get Service Returns Self
slug: embedding-generator-get-service-returns-self
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var self = Meai.EmbeddingGeneratorExtensions.GetService<CohereClient>(generator);

        self.Should().BeSameAs(client);
    }
}
