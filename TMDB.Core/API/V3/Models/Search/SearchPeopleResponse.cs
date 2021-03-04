using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Api.V3.Models.People;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class SearchPeopleResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<PersonMinified> Results { get; set; }
    }
}