using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Lists
{
    [ApiGetEndpoint("/list/{list_id}")]
    public class ListDetailsRequest : ListRequestBase
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}