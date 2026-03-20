# Generate



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

```csharp
using var client = new CohereClient(apiKey);

var response = await client.ChatAsync(new ChatRequest
{
    Message = "Hello, Cohere! Can you tell me a joke?",
});

Console.WriteLine("Cohere Response:");
Console.WriteLine(response.Value1!.Text);
```