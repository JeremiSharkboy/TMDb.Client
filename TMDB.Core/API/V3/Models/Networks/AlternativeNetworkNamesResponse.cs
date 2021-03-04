using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.Networks
{
    public class AlternativeNetworkNamesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("results")]
        public IEnumerable<AlternativeNetworkNamesResult> Results { get; set; }
    }
}