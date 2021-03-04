using Newtonsoft.Json;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.Movies
{
    public class MovieWatchProvidersResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("results")]
        public WatchProviderList Results { get; set; }
    }
}