using Newtonsoft.Json;

namespace TMDB.Core.Entities.Things
{
    public class Rating
    {
        [JsonProperty("value")]
        public virtual int Value { get; set; }
    }
}