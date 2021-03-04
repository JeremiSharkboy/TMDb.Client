using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.Movies
{
    public class MovieKeywordsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("keywords")]
        public virtual IEnumerable<Keyword> Keywords { get; set; }
    }
}