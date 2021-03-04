using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Account
{
    [ApiGetEndpoint("/account/{account_id}/watchlist/tv")]
    public class GetTVWatchlistRequest : AccountListBaseRequest
    {
    }
}