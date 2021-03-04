using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.GuestSessionRated
{
    [ApiGetEndpoint("/guest_session/{guest_session_id}/rated/movies")]
    public class GuestSessionRatedMoviesRequest : GuestSessionRatedRequest
    {
    }
}