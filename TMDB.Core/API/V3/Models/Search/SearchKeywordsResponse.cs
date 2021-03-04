using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class SearchKeywordsResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Keyword> Keywords { get; set; }
    }
}