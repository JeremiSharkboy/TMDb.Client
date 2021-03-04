using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Api.V3.Models.TVSeasons;

namespace TMDB.Core.Api.V3.Models.TVEpisodes
{
    public class TVEpisodesVideosResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        public virtual IEnumerable<TVSeasonsVideosResult> Videos { get; set; }
    }
}