using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Api.V3.Models.Configuration
{
    public class LanguagesConfigurationResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Language> Results { get; set; }
    }
}