dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/cohere-ai/cohere-developer-experience/main/cohere-openapi.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace Cohere \
  --clientClassName CohereClient \
  --targetFramework net9.0 \
  --output Generated \
  --exclude-deprecated-operations