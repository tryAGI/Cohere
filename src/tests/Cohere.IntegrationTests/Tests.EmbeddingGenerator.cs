using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_SingleText()
    {
        using var client = GetAuthenticatedCohereClient();

        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;
        var embeddings = await generator.GenerateAsync(
            ["Hello, world!"],
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "embed-english-v3.0",
            });

        embeddings.Should().ContainSingle();
        embeddings[0].Vector.Length.Should().BeGreaterThan(0);
    }

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

    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsMetadata()
    {
        using var client = CreateTestClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var metadata = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator);

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(CohereClient));
    }

    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var self = Meai.EmbeddingGeneratorExtensions.GetService<CohereClient>(generator);

        self.Should().BeSameAs(client);
    }

    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsNullForUnknownKey()
    {
        using var client = CreateTestClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var result = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator, serviceKey: "unknown");

        result.Should().BeNull();
    }
}
