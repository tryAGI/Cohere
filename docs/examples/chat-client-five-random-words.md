# Chat Client Five Random Words



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

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