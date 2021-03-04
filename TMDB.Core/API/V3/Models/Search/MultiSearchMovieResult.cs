using TMDB.Core.Entities.Media;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class MultiSearchMovieResult : MovieMinified
    {
        public MediaType MediaType { get; set; }
    }
}