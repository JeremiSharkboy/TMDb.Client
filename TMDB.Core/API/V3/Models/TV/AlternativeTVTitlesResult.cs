﻿using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.TV
{
    public class AlternativeTVTitlesResult
    {
        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}