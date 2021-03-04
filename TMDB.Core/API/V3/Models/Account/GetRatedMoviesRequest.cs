using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Account
{
    [ApiGetEndpoint("/account/{account_id}/rated/movies")]
    public class GetRatedMoviesRequest : AccountListBaseRequest
    {
    }
}