
using Google.Cloud.SecretManager.V1;

namespace Secret_Warehouse
{
    public class SecretsMang
    {
        private SecretManagerServiceClient client;
        private string projectId;
        private string dbConnectionString;
        
        public SecretsMang()
        {
            client = SecretManagerServiceClient.Create();
            projectId = "supernova-303818";
        }

        public string getDbString()
        {
            if (dbConnectionString != null)
            {
                return this.dbConnectionString;
            }
            else
            {
                const string secretId = "DatabaseConnectionString";
                const string versionId = "3";
                SecretVersionName secret = new SecretVersionName(projectId, secretId, versionId);
                AccessSecretVersionResponse result = client.AccessSecretVersion(secret);
                this.dbConnectionString = result.Payload.Data.ToStringUtf8();
                return this.dbConnectionString;
            }
                
        }
    }
}