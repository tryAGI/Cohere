# Chat Client Get Service Returns Self



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var self = Meai.ChatClientExtensions.GetService<CohereClient>(chatClient);
```