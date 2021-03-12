using Newtonsoft.Json;
using TMDB.Core.Entities.Media;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class MultiSearchTVResult : TVMinified
    {
        [JsonProperty("media_type")]

        public MediaType MediaType { get; set; }
    }
}