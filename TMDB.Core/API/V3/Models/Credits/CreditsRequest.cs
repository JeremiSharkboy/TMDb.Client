using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Credits
{
    [ApiGetEndpoint("/credit/{credit_id}")]
    public class CreditsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "credit_id",
            ParameterType = ParameterType.Path)]
        public string CreditId { get; set; }
    }
}