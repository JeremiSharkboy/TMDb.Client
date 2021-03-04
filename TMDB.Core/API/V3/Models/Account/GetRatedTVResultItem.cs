using Newtonsoft.Json;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Account
{
    public class GetRatedTVResultItem : TVMinified
    {
        [JsonProperty("rating")]
        public virtual double? Rating { get; set; }
    }
}