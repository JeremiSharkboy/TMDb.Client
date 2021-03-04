using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PeopleImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("profiles")]
        public IEnumerable<Image> Profiles { get; set; }
    }
}