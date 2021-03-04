using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TVChangesResponse : TMDbResponse
    {
        [JsonProperty("changes")]
        public virtual IEnumerable<TVChangesResult> Changes { get; set; }
    }
}