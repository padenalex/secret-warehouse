using System;
using Google.Api;
using Google.Api.Gax.Grpc;
using Google.Cloud.SecretManager.V1;

namespace Secret_Warehouse
{
    public class SecretsManager
    {
        public String GetSecret(string projectId = "supernova-303818", string secretId = "DatabaseConnectionString",
            string secretVersionId = "3")
        {

            var client = SecretManagerServiceClient.Create();

            var secretVersionName = new SecretVersionName(projectId, secretId, secretVersionId);

            var result = client.AccessSecretVersion(secretVersionName);

            return result.Payload.Data.ToStringUtf8();
        }
    }
}