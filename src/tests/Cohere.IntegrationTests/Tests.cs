namespace Cohere.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ICohereClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("COHERE_API_KEY") ??
            throw new AssertInconclusiveException("COHERE_API_KEY environment variable is not found.");

        var client = new CohereClient(apiKey);
        
        return client;
    }
}
