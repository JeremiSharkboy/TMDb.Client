using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/languages")]
    public class LanguagesConfigurationRequest : TMDbRequest
    {
    }
}