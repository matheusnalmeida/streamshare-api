using Newtonsoft.Json.Linq;

namespace StreamShare.Test.Integration.Fixtures
{
    public class GerenciaNetFixture : IDisposable
    {
        public JObject Credentials { get; private set; }
        public string QRCodeRelativePath { get; private set; }

        public GerenciaNetFixture()
        {
            JObject configurationJson = JObject.Parse(File.ReadAllText(@"Credentials\gerencianet.configuration.json"));
            Credentials = (JObject)configurationJson["credentials"];
            QRCodeRelativePath = (string)configurationJson["qr_code_relative_path"];
        }

        public void Dispose()
        {
            // ... clean up test data
            Credentials = null;
            QRCodeRelativePath = null;        
        }
    }
}
