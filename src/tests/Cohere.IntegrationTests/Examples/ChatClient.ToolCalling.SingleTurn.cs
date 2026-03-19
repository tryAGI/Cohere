/*
order: 70
title: Chat Client Tool Calling Single Turn
slug: chat-client-tool-calling-single-turn
*/

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
}
