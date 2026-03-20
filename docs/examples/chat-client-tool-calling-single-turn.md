# Chat Client Tool Calling Single Turn



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

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