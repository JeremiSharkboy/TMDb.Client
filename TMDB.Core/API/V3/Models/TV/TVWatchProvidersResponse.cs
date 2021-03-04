using Newtonsoft.Json;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TVWatchProvidersResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual WatchProviderList Results { get; set; }
    }
}