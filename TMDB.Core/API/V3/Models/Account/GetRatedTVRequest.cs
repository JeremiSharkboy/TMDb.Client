using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Account
{
    [ApiGetEndpoint("/account/{account_id}/rated/tv")]
    public class GetRatedTVRequest : AccountListBaseRequest
    {
    }
}