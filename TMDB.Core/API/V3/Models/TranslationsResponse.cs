using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models
{
    public class TranslationsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int? Id { get; set; }

        [JsonProperty("translations")]
        public virtual IEnumerable<Translation> Translations { get; set; }
    }
}