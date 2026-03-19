/*
order: 20
title: Chat Client Five Random Words
slug: chat-client-five-random-words
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords()
    {
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

        response.Messages.Should().ContainSingle();
        response.Text.Should().NotBeNullOrWhiteSpace();
        response.Messages[0].Role.Should().Be(Meai.ChatRole.Assistant);
        response.Messages[0].Text.Should().NotBeNullOrWhiteSpace();
    }
}
