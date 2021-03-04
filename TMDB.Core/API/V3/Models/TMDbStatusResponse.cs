using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models
{
    public class TMDbStatusResponse : TMDbResponse
    {
        [JsonProperty("status_code")]
        public virtual int StatusCode { get; set; }

        [JsonProperty("status_message")]
        public virtual string StatusMessage { get; set; }
    }
}