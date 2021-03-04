using Newtonsoft.Json;

namespace TMDB.Core.Entities.Things
{
    public class WatchProvider
    {
        [JsonProperty("display_priority")]
        public int? DisplayPriority { get; set; }

        [JsonProperty("provider_id")]
        public int ProviderId { get; set; }

        [JsonProperty("logo_path")]
        public string LogoPath { get; set; }

        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }
    }
}