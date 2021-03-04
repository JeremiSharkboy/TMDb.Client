using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Genres
{
    [ApiGetEndpoint("/genre/movie/list")]
    public class MovieGenresRequest : TMDbRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}