using Newtonsoft.Json;

namespace TMDB.Core.Entities.Things
{
    public class Gravatar
    {
        [JsonProperty("hash")]
        public virtual string Hash { get; set; }
    }
}