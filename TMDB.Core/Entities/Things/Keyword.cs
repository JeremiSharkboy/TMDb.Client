using Newtonsoft.Json;

namespace TMDB.Core.Entities.Things
{
    public class Keyword
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }
}