﻿using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.TVSeasons
{
    public class TVSeasonsAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }
}