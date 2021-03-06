﻿using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PersonTranslation
    {
        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("english_name")]
        public virtual string EnglishName { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("data")]
        public virtual PersonTranslationData Data { get; set; }
    }
}