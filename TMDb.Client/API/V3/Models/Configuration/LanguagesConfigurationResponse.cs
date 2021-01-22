﻿using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    public class LanguagesConfigurationResponse : TMDbResponse
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("english_name")]
        public virtual string Language { get; set; }

        [JsonProperty("name")]
        public virtual string OriginalLanguage { get; set; }
    }
}