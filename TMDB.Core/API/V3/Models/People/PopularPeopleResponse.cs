using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PopularPeopleResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public IEnumerable<PersonMinified> Results { get; set; }
    }
}