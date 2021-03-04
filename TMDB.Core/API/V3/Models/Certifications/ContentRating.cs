using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.Certifications
{
    public class ContentRating
    {
        [JsonProperty("order")]
        public virtual int Order { get; set; }

        [JsonProperty("certification")]
        public virtual string Certification { get; set; }

        [JsonProperty("meaning")]
        public virtual string Meaning { get; set; }
    }
}