using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/alternative_titles")]
    public class AlternativeMovieTitlesRequest : MovieBaseRequest
    {
        [ApiParameter(
            Name = "country",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string CountryCode { get; set; }
    }
}