using System;
using Google.Cloud.SecretManager.V1;

namespace Secret_Warehouse
{
    public class GetGoogleSecret
    {
        public String AccessSecretVersion(
            string projectId = "supernova-303818", string secretId = "DatabaseConnectionString",
            string secretVersionId = "3")
        {
            // Create the client.
            SecretManagerServiceClient client = SecretManagerServiceClient.Create();

            // Build the resource name.
            SecretVersionName secretVersionName = new SecretVersionName(projectId, secretId, secretVersionId);

            // Call the API.
            AccessSecretVersionResponse result = client.AccessSecretVersion(secretVersionName);

            // Convert the payload to a string. Payloads are bytes by default.
            String payload = result.Payload.Data.ToStringUtf8();
            return payload;
        }
    }
}