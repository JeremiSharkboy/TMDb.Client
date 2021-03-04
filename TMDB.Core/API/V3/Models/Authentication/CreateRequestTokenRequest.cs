using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Authentication
{
    [ApiGetEndpoint("/authentication/token/new")]
    public class CreateRequestTokenRequest : TMDbRequest
    {
    }
}