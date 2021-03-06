﻿using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Search
{
    [ApiGetEndpoint("/search/movie")]
    public class SearchMoviesRequest : SearchRequest
    {
        [ApiParameter(
            Name = "include_adult",
            Option = SerializationOption.ToLower,
            ParameterType = ParameterType.Query)]
        public virtual bool? IncludeAdult { get; set; }

        [ApiParameter(
            Name = "primary_release_year",
            ParameterType = ParameterType.Query)]
        public virtual int PrimaryReleaseYear { get; set; }

        [ApiParameter(
            Name = "year",
            ParameterType = ParameterType.Query)]
        public virtual int Year { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify a ISO 3166-1 code to filter release dates. Must be uppercase.
        /// pattern: ^[A-Z]{2}$
        /// </summary>
        [ApiParameter(
            Name = "region",
            ParameterType = ParameterType.Query)]
        public virtual string CountryCode { get; set; }
    }
}