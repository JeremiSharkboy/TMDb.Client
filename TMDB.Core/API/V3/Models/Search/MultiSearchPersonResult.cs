using Newtonsoft.Json;
using TMDB.Core.Api.V3.Models.People;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class MultiSearchPersonResult : PersonMinified
    {
        [JsonProperty("media_type")]

        public MediaType MediaType { get; set; }
    }
}