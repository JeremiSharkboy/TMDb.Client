﻿using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TV
{
    [ApiGetEndpoint("/tv/on_the_air")]
    public class TVOnTheAirRequest : TMDbRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify which page to query.
        ///     minimum: 1
        ///     maximum: 1000
        ///     default: 1
        /// </summary>
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual int Page { get; set; }
    }
}