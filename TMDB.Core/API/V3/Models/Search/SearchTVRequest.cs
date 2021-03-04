﻿using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Search
{
    [ApiGetEndpoint("/search/tv")]
    public class SearchTVRequest : SearchRequest
    {
        [ApiParameter(
            Name = "include_adult",
            Option = SerializationOption.ToLower,
            ParameterType = ParameterType.Query)]
        public virtual bool? IncludeAdult { get; set; }

        [ApiParameter(
            Name = "first_air_date_year",
            ParameterType = ParameterType.Query)]
        public virtual short? FirstAirDateYear { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}