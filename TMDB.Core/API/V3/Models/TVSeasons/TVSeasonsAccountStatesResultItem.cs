using Newtonsoft.Json;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.TVSeasons
{
    public class TVSeasonsAccountStatesResultItem
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("episode_number")]
        [JsonRequired]
        public virtual int? EpisodeNumber { get; set; }

        [JsonProperty("rated")]
        public virtual Rating Rated { get; set; }
    }
}