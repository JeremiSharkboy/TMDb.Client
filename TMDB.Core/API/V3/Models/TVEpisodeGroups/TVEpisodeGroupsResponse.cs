﻿using Newtonsoft.Json;
using System.Collections.Generic;
using TMDB.Core.Entities.Media;
using TMDB.Core.Entities.Organizations;

namespace TMDB.Core.Api.V3.Models.TVEpisodeGroups
{
    public class TVEpisodeGroupsResponse : TMDbResponse
    {
        [JsonProperty("episode_count")]
        public virtual int EpisodeCount { get; set; }

        [JsonProperty("group_count")]
        public virtual int GroupCount { get; set; }

        [JsonProperty("type")]
        public virtual int Type { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("description")]
        public virtual string Description { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("network")]
        public virtual Network Network { get; set; }

        [JsonProperty("groups")]
        public virtual IEnumerable<EpisodeGroup> Groups { get; set; }
    }
}