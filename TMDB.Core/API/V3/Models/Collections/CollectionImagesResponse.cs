using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Collections
{
    public class CollectionImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int? Id { get; set; }

        [JsonProperty("backdrops")]
        public virtual IEnumerable<Image> Backdrops { get; set; }

        [JsonProperty("posters")]
        public virtual IEnumerable<Image> Posters { get; set; }
    }
}