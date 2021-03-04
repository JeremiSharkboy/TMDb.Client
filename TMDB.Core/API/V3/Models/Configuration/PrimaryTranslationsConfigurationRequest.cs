using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/primary_translations")]
    public class PrimaryTranslationsConfigurationRequest : TMDbRequest
    {
    }
}