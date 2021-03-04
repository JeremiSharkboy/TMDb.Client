using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Movies
{
    public class MovieImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("backdrops")]
        public IEnumerable<Image> Backdrops { get; set; }

        [JsonProperty("posters")]
        public IEnumerable<Image> Posters { get; set; }
    }
}