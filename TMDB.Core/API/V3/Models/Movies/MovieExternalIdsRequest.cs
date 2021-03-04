using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/external_ids")]
    public class MovieExternalIdsRequest : MovieBaseRequest
    {
    }
}