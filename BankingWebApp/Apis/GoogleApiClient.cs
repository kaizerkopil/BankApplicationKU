using Microsoft.Extensions.Options;

namespace BankingWebApp.Apis
{
    public class GoogleApiClient
    {
        public string MapsApiKey { get; set; }
        public GoogleApiClient(IOptions<GoogleApiSettings> googleApiSettings)
        {
            MapsApiKey = googleApiSettings.Value.MapsApiKey;
        }
    }

    public class GoogleApiSettings
    {
        public string MapsApiKey { get; set; }
        public int Age { get; set; }

        public bool IsAdmin { get; set; }
    }
}
