using Microsoft.Extensions.AI;
using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_SingleTurn()
    {
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

        functionCall.Should().NotBeNull();
        functionCall!.Name.Should().Be("GetWeather");
    }

    [TestMethod]
    public async Task ChatClient_ToolCalling_MultiTurn()
    {
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

        functionCall.Should().NotBeNull();

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

        finalResponse.Text.Should().NotBeNullOrWhiteSpace();
        finalResponse.Text.Should().Contain("Seattle");
    }
}
