using Newtonsoft.Json;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TVAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("watchlist")]
        public bool Watchlist { get; set; }

        [JsonProperty("rated")]
        public Rating Rated { get; set; }
    }
}