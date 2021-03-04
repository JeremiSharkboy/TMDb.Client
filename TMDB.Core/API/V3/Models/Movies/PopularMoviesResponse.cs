using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Movies
{
    public class PopularMoviesResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public List<MovieMinified> Results { get; set; }
    }
}