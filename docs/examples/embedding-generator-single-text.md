# Embedding Generator Single Text



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

```csharp
using var client = GetAuthenticatedCohereClient();

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new Meai.EmbeddingGenerationOptions
    {
        ModelId = "embed-english-v3.0",
    });
```