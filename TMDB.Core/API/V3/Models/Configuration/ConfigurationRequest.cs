using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration")]
    public class ConfigurationRequest : TMDbRequest
    {
    }
}