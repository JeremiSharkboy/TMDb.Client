using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.People;

namespace TMDB.Core.Entities.Media
{
    public class Episode : EpisodeMinified
    {
        [JsonProperty("crew")]
        public virtual IEnumerable<Crew> Crew { get; set; }

        [JsonProperty("guest_stars")]
        public virtual IEnumerable<TVEpisodesGuestStar> GuestStars { get; set; }
    }
}