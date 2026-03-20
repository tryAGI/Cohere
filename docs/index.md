# Cohere

[![Nuget package](https://img.shields.io/nuget/vpre/Cohere)](https://www.nuget.org/packages/Cohere/)
[![dotnet](https://github.com/tryAGI/Cohere/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Cohere/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Cohere)](https://github.com/tryAGI/Cohere/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Cohere OpenAPI specification](https://raw.githubusercontent.com/cohere-ai/cohere-developer-experience/main/cohere-openapi.yaml) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `IChatClient` and `IEmbeddingGenerator` support

### Usage
```csharp
using Cohere;

using var client = new CohereClient(apiKey);

var response = await client.GenerateAsync(new GenerateRequest
{
    Prompt = "Hello, Cohere! Can you tell me a joke?",
});

Console.WriteLine("Cohere Response:");
Console.WriteLine(response.Generations[0].Text);
```

### Microsoft.Extensions.AI

The SDK implements [`IChatClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient) and [`IEmbeddingGenerator`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.iembeddinggenerator-2):
```csharp
using Cohere;
using Meai = Microsoft.Extensions.AI;

// IChatClient
Meai.IChatClient chatClient = new CohereClient(apiKey);
var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "Hello!")],
    new Meai.ChatOptions { ModelId = "command-r-08-2024" });

// IEmbeddingGenerator
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = new CohereClient(apiKey);
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new Meai.EmbeddingGenerationOptions { ModelId = "embed-english-v3.0" });
```

> **Note:** Use the `Meai` alias because the Cohere SDK has its own generated `IChatClient` interface.

<!-- EXAMPLES:START -->
### Chat Client Five Random Words Streaming


```csharp
using var client = GetAuthenticatedCohereClient();

Meai.IChatClient chatClient = client;
var updates = chatClient.GetStreamingResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")
    ],
    new Meai.ChatOptions
    {
        ModelId = "command-r-plus",
    });

var deltas = new List<string>();
await foreach (var update in updates)
{
    if (!string.IsNullOrWhiteSpace(update.Text))
    {
        deltas.Add(update.Text);
    }
}
```

### Chat Client Five Random Words


```csharp
using var client = GetAuthenticatedCohereClient();

Meai.IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")
    ],
    new Meai.ChatOptions
    {
        ModelId = "command-r-plus",
    });
```

### Chat Client Get Service Returns Chat Client Metadata


```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);
```

### Chat Client Get Service Returns Null For Unknown Key


```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var result = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient, serviceKey: "unknown");
```

### Chat Client Get Service Returns Self


```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var self = Meai.ChatClientExtensions.GetService<CohereClient>(chatClient);
```

### Chat Client Tool Calling Multi Turn


```csharp
using var client = GetAuthenticatedCohereClient();
Meai.IChatClient chatClient = client;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 72°F",
    "GetWeather",
    "Gets the current weather for a location");

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "What's the weather in Seattle?"),
};

var options = new Meai.ChatOptions
{
    ModelId = "command-r-plus",
    Tools = [getWeatherTool],
};

// First turn: model should call the tool
var response = await chatClient.GetResponseAsync(messages, options);

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .FirstOrDefault();

// Add assistant response with tool call and tool result
messages.AddRange(response.Messages);

var toolResult = await getWeatherTool.InvokeAsync(
    functionCall!.Arguments is { } args ? new AIFunctionArguments(args) : null);

messages.Add(new Meai.ChatMessage(Meai.ChatRole.Tool,
[
    new FunctionResultContent(functionCall.CallId, toolResult),
]));

// Second turn: model should respond with the weather info
var finalResponse = await chatClient.GetResponseAsync(messages, options);
```

### Chat Client Tool Calling Single Turn


```csharp
using var client = GetAuthenticatedCohereClient();
Meai.IChatClient chatClient = client;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 72°F",
    "GetWeather",
    "Gets the current weather for a location");

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "What's the weather in Seattle?")],
    new Meai.ChatOptions
    {
        ModelId = "command-r-plus",
        Tools = [getWeatherTool],
    });

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .FirstOrDefault();
```

### Embedding Generator Batch Texts


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

### Embedding Generator Get Service Returns Metadata


```csharp
using var client = CreateTestClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var metadata = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator);
```

### Embedding Generator Get Service Returns Null For Unknown Key


```csharp
using var client = CreateTestClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var result = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator, serviceKey: "unknown");
```

### Embedding Generator Get Service Returns Self


```csharp
using var client = CreateTestClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var self = Meai.EmbeddingGeneratorExtensions.GetService<CohereClient>(generator);
```

### Embedding Generator Single Text


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

### Generate


```csharp
using var client = new CohereClient(apiKey);

var response = await client.ChatAsync(new ChatRequest
{
    Message = "Hello, Cohere! Can you tell me a joke?",
});

Console.WriteLine("Cohere Response:");
Console.WriteLine(response.Value1!.Text);
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Cohere/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Cohere/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).