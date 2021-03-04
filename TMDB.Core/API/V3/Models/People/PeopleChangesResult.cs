using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PeopleChangesResult
    {
        [JsonProperty("key")]
        public virtual string Key { get; set; }

        [JsonProperty("items")]
        public virtual IEnumerable<PeopleChangesItem> Items { get; set; }
    }
}