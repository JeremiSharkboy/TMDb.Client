using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TVChangesResult
    {
        [JsonProperty("key")]
        public virtual string Key { get; set; }

        [JsonProperty("items")]
        public virtual List<TVChangesResultItem> Items { get; set; }
    }
}