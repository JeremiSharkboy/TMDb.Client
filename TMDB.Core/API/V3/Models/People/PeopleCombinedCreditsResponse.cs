using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Api.V3.Models.Trending;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PeopleCombinedCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        // TODO: Replace with proper model
        [JsonProperty("cast")]
        public virtual IEnumerable<TrendingResultItem> Cast { get; set; }

        // TODO: Replace with proper model
        [JsonProperty("crew")]
        public virtual IEnumerable<TrendingResultItem> Crew { get; set; }
    }
}