using Gerencianet.NETCore.SDK;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StreamShare.Domain.DTOs.GerenciaNet;
using StreamShare.Domain.DTOs.GerenciaNet.Response;
using StreamShare.Test.Integration.Fixtures;
using System.Drawing;

namespace StreamShare.Test.Integration
{
    public class GerenciaNetTests : IClassFixture<GerenciaNetFixture>
    {
        private readonly GerenciaNetFixture _gerenciaNetFixture;

        public GerenciaNetTests(GerenciaNetFixture gerenciaNetFixture)
        {
            _gerenciaNetFixture = gerenciaNetFixture;
        }

        [Fact]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
        public void PixGenerateQRCodeTest()
        {
            dynamic endpoints = new Endpoints(_gerenciaNetFixture.Credentials);

            var param = new
            {
                id = 1
            };

            var response = endpoints.PixGenerateQRCode(param);
            Console.WriteLine(response);

            // Generate QRCode Image to JPEG Format
            JObject jsonResponse = JObject.Parse(response);
            string img = (string)jsonResponse["imagemQrcode"];
            img = img.Replace("data:image/png;base64,", "");

            var qrCodeImage = Image.FromStream(new MemoryStream(Convert.FromBase64String(img)));
            qrCodeImage.Save($"{_gerenciaNetFixture.QRCodeRelativePath}\\RCodeImage.jpg");

            Assert.NotNull(qrCodeImage);
        }

        [Fact]
        public void CreateLocationTest()
        {
            dynamic endpoints = new Endpoints(_gerenciaNetFixture.Credentials);

            GetLocationResponseDTO getLocationDTO = GetCreatedLocations(endpoints);
            LocationDTO locationDTO;
            if (!getLocationDTO.Loc.Any())
            {
                var body = new
                {
                    tipoCob = "cob",
                };
                var responseCreateLocation = endpoints.PixCreateLocation(null, body) as string;
                locationDTO = JsonConvert.DeserializeObject<LocationDTO>(responseCreateLocation);
            }
            else {
                locationDTO = getLocationDTO.Loc.FirstOrDefault();
            }
            Assert.NotNull(getLocationDTO);
            Assert.True(
                locationDTO != null && 
                locationDTO.Id != 0 && 
                !string.IsNullOrEmpty(locationDTO.Location));
        }

        private static GetLocationResponseDTO GetCreatedLocations(dynamic endpoints)
        {
            var param = new
            {
                inicio = "2023-07-29T00:00:00.000Z",
                fim = "2023-07-29T23:59:59.000Z",
            };

            var responseListLocation = endpoints.PixListLocation(param) as string;
            var getLocationDTO = JsonConvert.DeserializeObject<GetLocationResponseDTO>(responseListLocation);
            return getLocationDTO;
        }
    }
}