using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Organizations;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class SearchCompaniesResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Company> Companies { get; set; }
    }
}