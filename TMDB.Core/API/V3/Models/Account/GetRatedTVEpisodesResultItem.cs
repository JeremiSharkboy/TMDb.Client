using Newtonsoft.Json;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Account
{
    public class GetRatedTVEpisodesResultItem : EpisodeMinified
    {
        [JsonProperty("rating")]
        public virtual double? Rating { get; set; }

        [JsonProperty("show_id")]
        public virtual int? ShowId { get; set; }
    }
}