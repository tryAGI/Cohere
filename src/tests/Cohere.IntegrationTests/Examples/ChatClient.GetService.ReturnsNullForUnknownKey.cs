/*
order: 40
title: Chat Client Get Service Returns Null For Unknown Key
slug: chat-client-get-service-returns-null-for-unknown-key
*/

using Meai = Microsoft.Extensions.AI;

namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_ReturnsNullForUnknownKey()
    {
        using var client = CreateTestClient();
        Meai.IChatClient chatClient = client;

        var result = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient, serviceKey: "unknown");

        result.Should().BeNull();
    }
}
