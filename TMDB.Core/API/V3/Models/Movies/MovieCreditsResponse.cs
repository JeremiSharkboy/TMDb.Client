using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.People;

namespace TMDB.Core.Api.V3.Models.Movies
{
    public class MovieCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("cast")]
        public virtual IEnumerable<TVSeasonsCreditsCast> Cast { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<TVSeasonsCreditsCrew> Crew { get; set; }
    }
}