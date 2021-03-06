﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDB.Core.Api.V3.Models.Find
{
    public class FindByIdTVResult : FindByIdMediaItem
    {
        // TDO:Do the same as released date or follow composition over inheritance??
        [JsonProperty("original_title")]
        public virtual string OriginalTitle { get; set; }

        // TDO:Do the same as released date or follow composition over inheritance??
        [JsonProperty("title")]
        public virtual string Title { get; set; }

        // TODO: Apply this over project or follow composition over inheritance??
        [JsonProperty("first_air_date")]
        public override DateTime? ReleaseDate { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> OriginCountry { get; set; }
    }
}