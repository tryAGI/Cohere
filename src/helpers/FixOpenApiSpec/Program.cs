using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("openapi: 3.1.0", "openapi: 3.0.1")
        .Replace("          discriminator:\n            propertyName: event_type\n            mapping:\n              stream-start: \"#/components/schemas/ChatStreamStartEvent\"\n              search-queries-generation: \"#/components/schemas/ChatSearchQueriesGenerationEvent\"\n              search-results: \"#/components/schemas/ChatSearchResultsEvent\"\n              text-generation: \"#/components/schemas/ChatTextGenerationEvent\"\n              citation-generation: \"#/components/schemas/ChatCitationGenerationEvent\"\n              tool-calls-generation: \"#/components/schemas/ChatToolCallsGenerationEvent\"\n              stream-end: \"#/components/schemas/ChatStreamEndEvent\"\n              tool-calls-chunk: \"#/components/schemas/ChatToolCallsChunkEvent\"", string.Empty)
        .Replace("          discriminator:\n            propertyName: type\n            mapping:\n              message-start: \"#/components/schemas/ChatMessageStartEvent\"\n              content-start: \"#/components/schemas/ChatContentStartEvent\"\n              content-delta: \"#/components/schemas/ChatContentDeltaEvent\"\n              content-end: \"#/components/schemas/ChatContentEndEvent\"\n              tool-plan-delta: \"#/components/schemas/ChatToolPlanDeltaEvent\"\n              tool-call-start: \"#/components/schemas/ChatToolCallStartEvent\"\n              tool-call-delta: \"#/components/schemas/ChatToolCallDeltaEvent\"\n              tool-call-end: \"#/components/schemas/ChatToolCallEndEvent\"\n              citation-start: \"#/components/schemas/CitationStartEvent\"\n              citation-end: \"#/components/schemas/CitationEndEvent\"\n              message-end: \"#/components/schemas/ChatMessageEndEvent\"", string.Empty)
        .Replace("          discriminator:\n            propertyName: event_type\n            mapping:\n              text-generation: \"#/components/schemas/GenerateStreamText\"\n              stream-end: \"#/components/schemas/GenerateStreamEnd\"\n              stream-error: \"#/components/schemas/GenerateStreamError\"", string.Empty)
        .Replace("                discriminator:\n                  propertyName: response_type\n                  mapping:\n                    embeddings_floats: \"#/components/schemas/EmbedFloatsResponse\"\n                    embeddings_by_type: \"#/components/schemas/EmbedByTypeResponse\"", string.Empty)
        .Replace("      discriminator:\n        propertyName: role\n        mapping:\n          CHATBOT: \"#/components/schemas/ChatMessage\"\n          SYSTEM: \"#/components/schemas/ChatMessage\"\n          USER: \"#/components/schemas/ChatMessage\"\n          TOOL: \"#/components/schemas/ToolMessage\"", string.Empty)
        .Replace("      discriminator:\n        propertyName: type\n        mapping:\n          text: \"#/components/schemas/TextResponseFormat\"\n          json_object: \"#/components/schemas/JSONResponseFormat\"", string.Empty)
        .Replace("      discriminator:\n        propertyName: event_type\n        mapping:\n          stream-start: \"#/components/schemas/ChatStreamStartEvent\"\n          search-queries-generation: \"#/components/schemas/ChatSearchQueriesGenerationEvent\"\n          search-results: \"#/components/schemas/ChatSearchResultsEvent\"\n          text-generation: \"#/components/schemas/ChatTextGenerationEvent\"\n          citation-generation: \"#/components/schemas/ChatCitationGenerationEvent\"\n          tool-calls-generation: \"#/components/schemas/ChatToolCallsGenerationEvent\"\n          stream-end: \"#/components/schemas/ChatStreamEndEvent\"\n          tool-calls-chunk: \"#/components/schemas/ChatToolCallsChunkEvent\"", string.Empty)
        .Replace("      discriminator:\n        propertyName: type\n        mapping:\n          tool: \"#/components/schemas/ToolSource\"\n          document: \"#/components/schemas/DocumentSource\"", string.Empty)
        .Replace("                discriminator:\n                  propertyName: type\n                  mapping:\n                    text: \"#/components/schemas/TextContent\"", string.Empty)
        .Replace("      discriminator:\n        propertyName: type\n        mapping:\n          text: \"#/components/schemas/TextContent\"", string.Empty)
        .Replace("            discriminator:\n              propertyName: type\n              mapping:\n                tool_result_object: \"#/components/schemas/ToolContent\"", string.Empty)
        .Replace("      discriminator:\n        propertyName: role\n        mapping:\n          assistant: \"#/components/schemas/AssistantMessage\"\n          system: \"#/components/schemas/SystemMessage\"\n          user: \"#/components/schemas/UserMessage\"\n          tool: \"#/components/schemas/ToolMessage-2\"", string.Empty)
        .Replace("      discriminator:\n        propertyName: type\n        mapping:\n          message-start: \"#/components/schemas/ChatMessageStartEvent\"\n          content-start: \"#/components/schemas/ChatContentStartEvent\"\n          content-delta: \"#/components/schemas/ChatContentDeltaEvent\"\n          content-end: \"#/components/schemas/ChatContentEndEvent\"\n          tool-plan-delta: \"#/components/schemas/ChatToolPlanDeltaEvent\"\n          tool-call-start: \"#/components/schemas/ChatToolCallStartEvent\"\n          tool-call-delta: \"#/components/schemas/ChatToolCallDeltaEvent\"\n          tool-call-end: \"#/components/schemas/ChatToolCallEndEvent\"\n          citation-start: \"#/components/schemas/CitationStartEvent\"\n          citation-end: \"#/components/schemas/CitationEndEvent\"\n          message-end: \"#/components/schemas/ChatMessageEndEvent\"", string.Empty)
        .Replace("      discriminator:\n        propertyName: event_type\n        mapping:\n          text-generation: \"#/components/schemas/GenerateStreamText\"\n          stream-end: \"#/components/schemas/GenerateStreamEnd\"\n          stream-error: \"#/components/schemas/GenerateStreamError\"", string.Empty)
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

openApiDocument.Components.SecuritySchemes.Add("Bearer", new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.Http,
    Scheme = "bearer",
});
openApiDocument.SecurityRequirements.Add(new OpenApiSecurityRequirement
{
    [new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Id = "Bearer",
            Type = ReferenceType.SecurityScheme
        }
    }] = new List<string>(),
});

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
return;