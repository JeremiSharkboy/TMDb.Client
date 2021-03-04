using System;
using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;
using TMDB.Core.Contracts;

namespace TMDB.Core.Api.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/account_states")]
    public class MovieAccountStatesRequest : MovieBaseRequest, IGuestSession
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.NoHyphen)]
        public virtual Guid? GuestSessionId { get; set; }
    }
}