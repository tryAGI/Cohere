namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Chat()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.ChatAsync(new ChatRequest
        {
            Message = "Hello, Cohere! Can you tell me a joke?",
        });

        response.IsValue1.Should().BeTrue();

        Console.WriteLine("Cohere Response:");
        Console.WriteLine(response.Value1!.Text);
    }
}
