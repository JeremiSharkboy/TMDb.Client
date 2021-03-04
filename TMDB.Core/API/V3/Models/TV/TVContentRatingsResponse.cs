﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TVContentRatingsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<TVContentRatingsResult> Results { get; set; }
    }
}