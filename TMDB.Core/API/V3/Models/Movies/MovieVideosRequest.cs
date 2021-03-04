﻿using System;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Movies
{
    /// <summary>
    /// Get the videos that have been added to a movie.
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/videos")]
    public class MovieVideosRequest : MovieBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        // TODO: Add null or 2 char count validation")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}