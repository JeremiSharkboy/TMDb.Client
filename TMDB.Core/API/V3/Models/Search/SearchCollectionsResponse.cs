using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class SearchCollectionsResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<CollectionMinified> Collections { get; set; }
    }
}