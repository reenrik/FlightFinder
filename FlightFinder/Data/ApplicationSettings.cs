using Newtonsoft.Json;

namespace FlightFinder.Data
{
    public class ApplicationSettings
    {
        [JsonProperty("dataProvider")]
        public DataProviderType DataProvider { get; set; }

        [JsonProperty("dataConnectionString")]
        public string DataConnectionString { get; set; }
    }
}