using Newtonsoft.Json;

namespace TMDB.Core.Entities.People
{
    public class TVSeasonsCreditsCrew : TVEpisodesGuestStar
    {
        [JsonProperty("job")]
        public virtual string Job { get; set; }

        [JsonProperty("department")]
        public virtual string Department { get; set; }
    }
}