using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Movies
{
    /// <summary>
    /// Get the keywords that have been added to a movie.
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/keywords")]
    public class MovieKeywordsRequest : MovieBaseRequest
    {
    }
}