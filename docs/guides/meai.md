# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Cohere SDK implements `IChatClient` and `IEmbeddingGenerator<string, Embedding<float>>` and provides `AIFunction` tool wrappers, all compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

!!! warning "Namespace Conflict"
    This SDK has a generated `IChatClient` interface that conflicts with `Microsoft.Extensions.AI.IChatClient`. Use the `Meai` alias pattern shown below.

!!! note "Streaming"
    Cohere's chat API does not support true server-sent events streaming. The `GetStreamingResponseAsync` method simulates streaming by returning the full response as a single update.

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `IChatClient` | Partial (text, tool calling; no true streaming) |
| `IEmbeddingGenerator<string, Embedding<float>>` | Full |

## IChatClient

### Installation

```bash
dotnet add package Cohere
```

### Basic Usage

Because the SDK generates its own `IChatClient` interface, you must use a namespace alias:

```csharp
using Cohere;
using Meai = Microsoft.Extensions.AI;

using var client = new CohereClient(apiKey);
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    "What is the capital of France?",
    new Meai.ChatOptions
    {
        ModelId = "command-r-08-2024",
    });

Console.WriteLine(response.Text);
```

### Tool Calling

```csharp
using CSharpToJsonSchema;
using Meai = Microsoft.Extensions.AI;

[GenerateJsonSchema]
public interface IWeatherTools
{
    [Description("Gets the current weather for a location.")]
    string GetWeather(
        [Description("The city name")] string city);
}

Meai.IChatClient chatClient = client;
var service = new WeatherToolsService();

var response = await chatClient.GetResponseAsync(
    "What's the weather in Paris?",
    new Meai.ChatOptions
    {
        ModelId = "command-r-08-2024",
        Tools = service.AsTools().AsAITools(),
    });
```

### Accessing Client Metadata

When using the `Meai` alias, call extension methods explicitly:

```csharp
var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);
var self = Meai.ChatClientExtensions.GetService<CohereClient>(chatClient);
```

## IEmbeddingGenerator

### Basic Usage

```csharp
using Cohere;
using Meai = Microsoft.Extensions.AI;

using var client = new CohereClient(apiKey);
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(
    ["Hello, world!", "How are you?"],
    new Meai.EmbeddingGenerationOptions
    {
        ModelId = "embed-english-v3.0",
    });

foreach (var embedding in embeddings)
{
    Console.WriteLine($"Dimensions: {embedding.Vector.Length}");
}
```
