﻿using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class TopRatedTVResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<TVMinified> Results { get; set; }
    }
}