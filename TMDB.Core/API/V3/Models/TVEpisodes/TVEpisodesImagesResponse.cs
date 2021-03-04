using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.TVEpisodes
{
    public class TVEpisodesImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("stills")]
        public virtual IEnumerable<Image> Stills { get; set; }
    }
}