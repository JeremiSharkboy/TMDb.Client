﻿using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models
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
}