using Newtonsoft.Json;

namespace TMDB.Core.Entities.Things
{
    public class Avatar
    {
        [JsonProperty("gravatar")]
        public virtual Gravatar Gravatar { get; set; }
    }
}