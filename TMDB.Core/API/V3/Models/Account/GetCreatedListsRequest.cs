using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Account
{
    [ApiGetEndpoint("/account/{account_id}/lists")]
    public class GetCreatedListsRequest : TMDbRequest
    {
        public GetCreatedListsRequest()
        {
            Page = 1;
        }

        [ApiParameter(
            Name = "account_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int? AccountId { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        public virtual int Page { get; set; }
    }
}