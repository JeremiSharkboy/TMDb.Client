using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Movies
{
    // TODO: Is this class really needed??
    public abstract class MovieBaseRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "movie_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual uint MovieId { get; set; }
    }
}