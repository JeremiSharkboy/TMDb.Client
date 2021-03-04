using TMDB.Core.Entities.Media;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class MultiSearchTVResult : TVMinified
    {
        public MediaType MediaType { get; set; }
    }
}