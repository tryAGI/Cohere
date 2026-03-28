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

# Fix CS0618: Generated UpdateFinetunedModelRequest references the deprecated Settings type.
# Since TreatWarningsAsErrors is enabled, suppress this specific warning in affected files.
for file in Generated/Cohere.Models.UpdateFinetunedModelRequest.g.cs; do
  if [ -f "$file" ]; then
    sed -i '' '1s/^/#pragma warning disable CS0618\n/' "$file"
  fi
done
