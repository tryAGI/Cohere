/*
order: 10
title: Chat Client Five Random Words Streaming
slug: chat-client-five-random-words-streaming
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_FiveRandomWords_Streaming()
    {
        using var client = GetAuthenticatedCohereClient();

        Meai.IChatClient chatClient = client;
        var updates = chatClient.GetStreamingResponseAsync(
            [
                new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")
            ],
            new Meai.ChatOptions
            {
                ModelId = "command-r-plus",
            });

        var deltas = new List<string>();
        await foreach (var update in updates)
        {
            if (!string.IsNullOrWhiteSpace(update.Text))
            {
                deltas.Add(update.Text);
            }
        }

        deltas.Should().NotBeEmpty();
        string.Concat(deltas).Should().NotBeNullOrWhiteSpace();
    }
}
