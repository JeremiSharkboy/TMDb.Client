using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.Authentication
{
    public class DeleteSessionResponse : TMDbResponse
    {
        [JsonProperty("success")]
        public virtual bool IsSuccess { get; set; }
    }
}