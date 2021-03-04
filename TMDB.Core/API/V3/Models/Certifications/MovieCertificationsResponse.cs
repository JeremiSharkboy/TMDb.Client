using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.Certifications
{
    public class MovieCertificationsResponse : TMDbResponse
    {
        [JsonProperty("certifications")]
        public virtual MovieCertifications Certifications { get; set; }
    }
}