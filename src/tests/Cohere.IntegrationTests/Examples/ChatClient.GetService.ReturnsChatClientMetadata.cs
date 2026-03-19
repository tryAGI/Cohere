/*
order: 30
title: Chat Client Get Service Returns Chat Client Metadata
slug: chat-client-get-service-returns-chat-client-metadata
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_ReturnsChatClientMetadata()
    {
        using var client = CreateTestClient();
        Meai.IChatClient chatClient = client;

        var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(CohereClient));
    }
}
