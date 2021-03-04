using Newtonsoft.Json;

namespace TMDB.Core.Entities.People
{
    public class TVSeasonsCreditsCast : TVSeasonsCreditsCrew
    {
        [JsonProperty("order")]
        public virtual int? Order { get; set; }

        [JsonProperty("character")]
        public virtual string Character { get; set; }
    }
}