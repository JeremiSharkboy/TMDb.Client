using Newtonsoft.Json;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.TVEpisodes
{
    public class TVEpisodesAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("rated")]
        public virtual Rating Rated { get; set; }
    }
}