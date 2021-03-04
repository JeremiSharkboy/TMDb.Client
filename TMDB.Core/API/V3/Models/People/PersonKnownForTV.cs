using TMDB.Core.Entities.Media;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PersonKnownForTV : TVMinified
    {
        public MediaType MediaType { get; set; }
    }
}