namespace Cohere.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ICohereClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("COHERE_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            throw new AssertInconclusiveException("COHERE_API_KEY environment variable is not found.");

        var client = new CohereClient(apiKey);

        return client;
    }

    private static CohereClient GetAuthenticatedCohereClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("COHERE_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            throw new AssertInconclusiveException("COHERE_API_KEY environment variable is not found.");

        return new CohereClient(apiKey);
    }

    private static CohereClient CreateTestClient()=> new(apiKey: "test-key");
}
