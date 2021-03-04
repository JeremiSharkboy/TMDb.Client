using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Networks
{
    public class NetworkImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("logos")]
        public IEnumerable<Image> Logos { get; set; }
    }
}