﻿using Newtonsoft.Json;
using System;

namespace TMDB.Core.Api.V3.Models.Authentication
{
    public class AuthenticationResponse : TMDbResponse
    {
        [JsonProperty("success")]
        public virtual bool IsSuccess { get; set; }

        [JsonProperty("expires_at")]
        public virtual DateTime? Expiration { get; set; }
    }
}