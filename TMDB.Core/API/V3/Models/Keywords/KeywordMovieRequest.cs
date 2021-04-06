using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Keywords
{
    [ApiGetEndpoint("/keyword/{keyword_id}/movies")]
    public class KeywordMovieRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "keyword_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual uint KeywordId { get; set; }

        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Range(1, 1000)]
        public virtual uint Page { get; set; }


        [ApiParameter(
            Name = "include_adult",
            Option = SerializationOption.ToLower,
            ParameterType = ParameterType.Query)]
        public virtual bool? IsAdult { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}