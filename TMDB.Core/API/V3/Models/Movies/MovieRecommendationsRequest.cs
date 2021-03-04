﻿using System;
using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Movies
{
    /// <summary>
    /// Get a list of recommended movies for a movie.
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/recommendations")]
    public class MovieRecommendationsRequest : MovieBaseRequest
    {
        public MovieRecommendationsRequest()
        {
            Page = 1;
        }

        /// <summary>
        /// Specify which page to query.
        ///     minimum: 1
        ///     maximum: 1000
        ///     default: 1
        /// </summary>
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Range(1, 1000)]
        public virtual int Page { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        // TODO: Add null or 2 char count validation")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}