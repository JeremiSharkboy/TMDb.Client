using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.Genres
{
    public class MovieGenresResponse : TMDbResponse
    {
        [JsonProperty("genres")]
        public virtual IEnumerable<Genre> Genres { get; set; }
    }
}