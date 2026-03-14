# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Cohere](https://cohere.com/) AI platform, auto-generated from the official Cohere OpenAPI specification using [AutoSDK](https://github.com/tryAGI/AutoSDK). Published as a NuGet package under the `Cohere` package name.

## Build Commands

```bash
# Build the solution
dotnet build Cohere.slnx

# Build for release (also produces NuGet package)
dotnet build Cohere.slnx -c Release

# Run integration tests (requires COHERE_API_KEY env var)
dotnet test src/tests/Cohere.IntegrationTests/Cohere.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Cohere && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Cohere/Generated/`.

1. `src/libs/Cohere/openapi.yaml` -- the Cohere OpenAPI spec (fetched from the `cohere-developer-experience` repo)
2. `src/libs/Cohere/generate.sh` -- orchestrates: download the official spec, run AutoSDK CLI, output to `Generated/`
3. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Cohere/` | Main SDK library (`CohereClient`) |
| `src/tests/Cohere.IntegrationTests/` | Integration tests against real Cohere API |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |
| `src/helpers/TrimmingHelper/` | NativeAOT/trimming compatibility validator |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### Key Conventions

- No hand-written extension files -- the SDK is purely generated code
- The client class is named `CohereClient`
- The namespace is `Cohere`

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
