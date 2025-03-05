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

## Support

Priority place for bugs: https://github.com/tryAGI/Cohere/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Cohere/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).