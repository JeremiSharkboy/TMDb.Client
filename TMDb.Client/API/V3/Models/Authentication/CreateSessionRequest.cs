﻿using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class CreateSessionRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "request_token")]
        public string RequestToken { get; set; }
    }
}