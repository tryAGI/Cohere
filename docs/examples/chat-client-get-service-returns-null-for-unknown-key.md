# Chat Client Get Service Returns Null For Unknown Key



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var result = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient, serviceKey: "unknown");
```