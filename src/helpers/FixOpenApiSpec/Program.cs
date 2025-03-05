using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;
using Microsoft.OpenApi.Validations;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

yamlOrJson = yamlOrJson.Replace("18446744073709552000", $"{int.MaxValue}");

if (OpenApi31Support.IsOpenApi31(yamlOrJson))
{
    yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
}

var openApiDocument = new OpenApiStringReader(new OpenApiReaderSettings
{
    RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
}).Read(yamlOrJson, out var diagnostics);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

openApiDocument.Components.Schemas["Source"]!.Discriminator = null;
openApiDocument.Components.Schemas["TruncationStrategy"]!.Discriminator = null;

yamlOrJson = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(yamlOrJson, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOrJson);
return;