﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PeopleChangesResponse : TMDbResponse
    {
        [JsonProperty("changes")]
        public virtual IEnumerable<PeopleChangesResult> Changes { get; set; }
    }

    public class OriginalValue
    {
        [JsonProperty("profile")]
        public virtual Profile Profile { get; set; }
    }

    public class Profile
    {
        [JsonProperty("file_path")]
        public virtual string FilePath { get; set; }
    }
}