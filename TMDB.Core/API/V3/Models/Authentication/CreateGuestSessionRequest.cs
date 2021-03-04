using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Authentication
{
    [ApiGetEndpoint("/authentication/guest_session/new")]
    public class CreateGuestSessionRequest : TMDbRequest
    {
    }
}