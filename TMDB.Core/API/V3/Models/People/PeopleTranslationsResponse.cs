﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PeopleTranslationsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("translations")]
        public virtual IEnumerable<PersonTranslation> Translations { get; set; }
    }
}