using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}/movie_credits")]
    public class PeopleMovieCreditsRequest : PeopleBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}