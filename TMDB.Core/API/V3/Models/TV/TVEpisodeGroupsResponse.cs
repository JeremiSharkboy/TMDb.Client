﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TVEpisodeGroupsResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<TVEpisodeGroupsScreenedTheatricallyResult> Results { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }
}