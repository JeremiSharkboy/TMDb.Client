using Newtonsoft.Json;
using System;
using TMDB.Core.Contracts;

namespace TMDB.Core.Api.V3.Models.Authentication
{
    public class CreateGuestSessionResponse : AuthenticationResponse, IGuestSession
    {
        [JsonProperty("guest_session_id")]
        public virtual Guid? GuestSessionId { get; set; }
    }
}