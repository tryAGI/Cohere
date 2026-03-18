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

    [TestMethod]
    public void ChatClient_GetService_ReturnsChatClientMetadata()
    {
        using var client = CreateTestClient();
        Meai.IChatClient chatClient = client;

        var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(CohereClient));
    }

    [TestMethod]
    public void ChatClient_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        Meai.IChatClient chatClient = client;

        var self = Meai.ChatClientExtensions.GetService<CohereClient>(chatClient);

        self.Should().BeSameAs(client);
    }

    [TestMethod]
    public void ChatClient_GetService_ReturnsNullForUnknownKey()
    {
        using var client = CreateTestClient();
        Meai.IChatClient chatClient = client;

        var result = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient, serviceKey: "unknown");

        result.Should().BeNull();
    }
}
