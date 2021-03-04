﻿using System;
using TMDB.Core.Attributes;
using TMDB.Core.Contracts;

namespace TMDB.Core.Api.V3.Models.TV
{
    /// <summary>
    /// Remove your rating for a TV show.
    /// A valid session or guest session ID is required.You can read more about how this works.
    /// https://developers.themoviedb.org/3/authentication/how-do-i-generate-a-session-id
    /// </summary>
    [ApiDeleteEndpoint("/tv/{tv_id}/rating")]
    public class DeleteTVRatingRequest : TVBaseRequest, IGuestSession
    {
        /// <summary>
        /// default: application/json;charset=utf-8
        /// </summary>
        //[ApiParameter(
        //    Name = "Content-Type",
        //    ParameterType = ParameterType.Header)]
        //public virtual string ContentType => Constants.ContentType.Json;

        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.NoHyphen)]
        public virtual Guid? GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        public virtual string SessionId { get; set; }
    }
}