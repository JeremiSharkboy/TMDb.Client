﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models
{
    public class TMDbCollectionResponse : TMDbResponse
    {
        [JsonProperty("page")]
        public virtual int Page { get; set; }

        [JsonProperty("total_pages")]
        public virtual int TotalPages { get; set; }

        [JsonProperty("total_results")]
        public virtual int TotalResults { get; set; }
    }

    public class TMDbCollectionResponse<T> : TMDbResponse
    {
        [JsonProperty("page")]
        public virtual int Page { get; set; }

        [JsonProperty("total_pages")]
        public virtual int TotalPages { get; set; }

        [JsonProperty("total_results")]
        public virtual int TotalResults { get; set; }

        public virtual IEnumerable<T> Results { get; set; }
    }
}