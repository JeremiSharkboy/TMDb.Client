using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class SearchTVResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<TVMinified> Results { get; set; }
    }
}