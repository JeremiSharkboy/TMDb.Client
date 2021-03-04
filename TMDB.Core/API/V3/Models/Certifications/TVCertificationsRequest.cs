using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Certifications
{
    [ApiGetEndpoint("/certification/tv/list")]
    public class TVCertificationsRequest : TMDbRequest
    {
    }
}