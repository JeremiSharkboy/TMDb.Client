﻿using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Keywords
{
    public class KeywordMovieResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<MovieMinified> Results { get; set; }

    }
}