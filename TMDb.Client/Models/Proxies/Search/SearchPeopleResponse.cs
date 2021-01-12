﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchPeopleResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<SearchPeopleResult> Results { get; set; }
    }

    public class SearchPeopleResult : SearchResult
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("known_for")]
        public virtual IEnumerable<SearchMediaResult> KnownFor { get; set; }
    }
}