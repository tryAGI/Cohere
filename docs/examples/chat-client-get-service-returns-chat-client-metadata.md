# Chat Client Get Service Returns Chat Client Metadata



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);
```