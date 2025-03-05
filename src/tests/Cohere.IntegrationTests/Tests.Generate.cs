namespace Cohere.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Generate()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.GenerateAsync(new GenerateRequest
        {
            Prompt = "Hello, Cohere! Can you tell me a joke?",
        });

        // Display the generated text
        Console.WriteLine("Cohere Response:");
        Console.WriteLine(response.Generations[0].Text);
    }
}
