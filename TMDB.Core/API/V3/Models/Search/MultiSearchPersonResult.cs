using TMDB.Core.Api.V3.Models.People;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Search
{
    public class MultiSearchPersonResult : PersonMinified
    {
        public MediaType MediaType { get; set; }
    }
}