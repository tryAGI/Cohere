# Embedding Generator Batch Texts



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

```csharp
using var client = GetAuthenticatedCohereClient();

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello", "World", "Test"],
    new Meai.EmbeddingGenerationOptions
    {
        ModelId = "embed-english-v3.0",
    });

foreach (var embedding in embeddings)
{
}
```