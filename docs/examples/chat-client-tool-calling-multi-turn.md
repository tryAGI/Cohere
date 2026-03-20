# Chat Client Tool Calling Multi Turn



This example assumes `using Cohere;` is in scope and `apiKey` contains your Cohere API key.

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