using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Entities.Things
{
    public class Collection : CollectionMinified
    {
        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("parts")]
        public IEnumerable<MovieMinified> Parts { get; set; }
    }
}