using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.Lists
{
    public class CreateListResponse : TMDbStatusResponse
    {
        [JsonProperty("success")]
        public virtual bool Success { get; set; }

        [JsonProperty("list_id")]
        public virtual int ListId { get; set; }
    }
}