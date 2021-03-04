using Newtonsoft.Json;
using TMDB.Core.Api.V3.Models.Movies;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TVReviewsResponse : TMDbCollectionResponse<MovieReviewsItem>
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }
}