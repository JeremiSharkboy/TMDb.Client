using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Certifications
{
    [ApiGetEndpoint("/certification/movie/list")]
    public class MovieCertificationsRequest : TMDbRequest
    {
    }
}