using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Discover
{
    public class DiscoverTVResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual List<TVMinified> Results { get; set; }
    }
}