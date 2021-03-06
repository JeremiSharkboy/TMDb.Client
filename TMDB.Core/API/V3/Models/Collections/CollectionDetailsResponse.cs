﻿using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;

namespace TMDB.Core.Api.V3.Models.Collections
{
    // TODO: Review endpoint properties")]
    public class CollectionDetailsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int? Id { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("parts")]
        public virtual IEnumerable<MovieMinified> Parts { get; set; }
    }
}