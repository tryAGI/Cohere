/*
order: 50
title: Chat Client Get Service Returns Self
slug: chat-client-get-service-returns-self
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        Meai.IChatClient chatClient = client;

        var self = Meai.ChatClientExtensions.GetService<CohereClient>(chatClient);

        self.Should().BeSameAs(client);
    }
}
