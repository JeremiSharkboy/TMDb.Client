﻿using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/credits")]
    public class MovieCreditsRequest : MovieBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        // TODO: Add null or 2 char count validation with regex")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}