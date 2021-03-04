using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/timezones")]
    public class TimezonesConfigurationRequest : TMDbRequest
    {
    }
}