using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TVVideosResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<Video> Results { get; set; }
    }
}