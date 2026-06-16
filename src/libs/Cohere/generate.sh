#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/cohere-ai/cohere-developer-experience/main/cohere-openapi.yaml

cd -- "$(dirname -- "$0")"
install_autosdk_cli

fetch_spec -fL -o openapi.yaml https://raw.githubusercontent.com/cohere-ai/cohere-developer-experience/main/cohere-openapi.yaml
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Cohere \
  --clientClassName CohereClient \
  --targetFramework net10.0 \
  --output Generated \
  --auth-env-var COHERE_API_KEY \
  --exclude-deprecated-operations
