namespace Cohere.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public CohereApi GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("COHERE_API_KEY") ??
            throw new AssertInconclusiveException("COHERE_API_KEY environment variable is not found.");

        var api = new CohereApi(apiKey);
        
        return api;
    }
}
