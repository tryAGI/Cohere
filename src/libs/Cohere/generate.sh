dotnet tool install --global openapigenerator.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/cohere-ai/cohere-developer-experience/main/cohere-openapi.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
oag generate openapi.yaml \
  --namespace Cohere \
  --clientClassName CohereApi \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations