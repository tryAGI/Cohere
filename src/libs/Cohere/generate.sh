#!/usr/bin/env bash
set -euo pipefail
cd -- "$(dirname -- "$0")"

if ! dotnet tool update --global autosdk.cli --prerelease; then
  dotnet tool install --global autosdk.cli --prerelease
fi

curl -fL -o openapi.yaml https://raw.githubusercontent.com/cohere-ai/cohere-developer-experience/main/cohere-openapi.yaml
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Cohere \
  --clientClassName CohereClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
