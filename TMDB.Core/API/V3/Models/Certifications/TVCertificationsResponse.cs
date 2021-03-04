using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.Certifications
{
    public class TVCertificationsResponse : TMDbResponse
    {
        [JsonProperty("certifications")]
        public virtual Certifications Certifications { get; set; }
    }
}