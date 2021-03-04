using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Search
{
    [ApiGetEndpoint("/search/collection")]
    public class SearchCollectionsRequest : SearchRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}