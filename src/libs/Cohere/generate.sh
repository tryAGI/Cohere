#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/cohere-ai/cohere-developer-experience/main/cohere-openapi.yaml

cd -- "$(dirname -- "$0")"

dotnet tool install --global autosdk.cli --prerelease

curl -fL -o openapi.yaml https://raw.githubusercontent.com/cohere-ai/cohere-developer-experience/main/cohere-openapi.yaml
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Cohere \
  --clientClassName CohereClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
