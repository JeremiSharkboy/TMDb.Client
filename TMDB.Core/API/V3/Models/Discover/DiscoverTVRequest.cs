﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Discover
{
    /// <summary>
    /// Discover TV shows by different types of data like average rating,
    /// number of votes, genres, the network they aired on and air dates.
    ///
    /// Discover also supports a nice list of sort options.
    /// See below for all of the available options.
    ///
    /// Also note that a number of filters support being comma(,) or
    /// pipe(|) separated.Comma's are treated like an AND and query while
    /// pipe's are an OR.
    ///
    /// Some examples of what can be done with discover can be found
    /// https://www.themoviedb.org/documentation/api/discover.
    /// </summary>
    [ApiGetEndpoint("/discover/tv")]
    public class DiscoverTVRequest : TMDbRequest
    {
        public DiscoverTVRequest()
        {
            Page = 1;
            SortBy = DiscoverTVSortBy.PopularityDescending;
        }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Choose from one of the many available sort options.
        ///     Allowed Values:
        ///         vote_average.desc   , vote_average.asc,
        ///         first_air_date.desc , first_air_date.asc,
        ///         popularity.desc     , popularity.asc
        ///     default: popularity.desc
        /// </summary>
        [ApiParameter(
            Name = "sort_by",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.EnumDescription)]
        public virtual DiscoverTVSortBy SortBy { get; set; }

        /// <summary>
        /// Filter and only include TV shows that have a air date (by looking
        /// at all episodes) that is greater or equal to the specified value.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "air_date.gte",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.DateOnly)]
        public virtual DateTime? AirDateGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include TV shows that have a air date (by looking at
        /// all episodes) that is less than or equal to the specified value.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "air_date.lte",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.DateOnly)]
        public virtual DateTime? AirDateLessThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include TV shows that have a original air date
        /// that is greater or equal to the specified value. Can be used
        /// in conjunction with the "include_null_first_air_dates" filter
        /// if you want to include items with no air date.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "first_air_date.gte",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? FirstAirDateGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include TV shows that have a original air date
        /// that is less than or equal to the specified value. Can be used
        /// in conjunction with the "include_null_first_air_dates" filter
        /// if you want to include items with no air date.
        /// equal to the specified value.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "first_air_date.lte",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? FirstAirDateLessThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include TV shows that have a original air
        /// date year that equal to the specified value. Can be used
        /// in conjunction with the "include_null_first_air_dates"
        /// filter if you want to include items with no air date.
        /// </summary>
        [ApiParameter(
            Name = "first_air_date_year",
            ParameterType = ParameterType.Query)]
        public virtual short? FirstAirDateYear { get; set; }

        /// <summary>
        /// Specify the page of results to query.
        ///     minimum: 1
        ///     maximum: 1000
        ///     default: 1
        /// </summary>
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Range(1, 1000)]
        public virtual int Page { get; set; }

        /// <summary>
        /// Used in conjunction with the air_date.gte/lte filter
        /// to calculate the proper UTC offset.
        ///     default: America/New_York
        /// </summary>
        [ApiParameter(
            Name = "timezone",
            ParameterType = ParameterType.Query)]
        public virtual string Timezone { get; set; }

        /// <summary>
        /// Filter and only include TV that have a vote count that
        /// is greater or equal to the specified value.
        ///     minimum: 0
        /// </summary>
        [ApiParameter(
            Name = "vote_count.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteCountGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include TV that have a rating that is
        /// greater or equal to the specified value.
        ///     minimum: 1
        /// </summary>
        [ApiParameter(
            Name = "vote_average.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteAverageGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            Delimeter = nameof(WithGenreIdsDelimeter),
            Name = "with_genres",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithGenreIds { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameterIgnore]
        public virtual Delimeter WithGenreIdsDelimeter { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            Delimeter = nameof(WithoutGenreIdsDelimeter),
            Name = "without_genres",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithoutGenreIds { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameterIgnore]
        public virtual Delimeter WithoutGenreIdsDelimeter { get; set; }

        /// <summary>
        /// Comma separated value of network ids that you want to include in the results.
        /// </summary>
        [ApiParameter(
            Name = "with_networks",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithNetworkIds { get; set; }

        /// <summary>
        /// Filter and only include TV that have a runtime that is greater or equal to a value.
        /// </summary>
        [ApiParameter(
            Name = "with_runtime.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? WithRuntimeGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include TV that have a runtime that is less than or equal to a value.
        /// </summary>
        [ApiParameter(
            Name = "with_runtime.lte",
            ParameterType = ParameterType.Query)]
        public virtual int? WithRuntimeLessThanOrEqualTo { get; set; }

        /// <summary>
        /// Use this filter to include TV shows that don't have an
        /// air date while using any of the "first_air_date" filters.
        /// </summary>
        [ApiParameter(
            Name = "include_null_first_air_dates",
            Option = SerializationOption.ToLower,
            ParameterType = ParameterType.Query)]
        public virtual bool? IncludeNullFirstAirDates { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "with_original_language",
            ParameterType = ParameterType.Query)]
        public virtual string WithOriginalLanguageAbbreviation { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            Delimeter = nameof(WithKeywordIdsDelimeter),
            Name = "with_keywords",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithKeywordIds { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameterIgnore]
        public virtual Delimeter WithKeywordIdsDelimeter { get; set; }
        
        /// <summary>
        /// </summary>
        [ApiParameter(
            Delimeter = nameof(WithoutKeywordIdsDelimeter),
            Name = "without_keywords",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithoutKeywordIds { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameterIgnore]
        public virtual Delimeter WithoutKeywordIdsDelimeter { get; set; }

        /// <summary>
        /// Filter results to include items that have been screened theatrically.
        /// </summary>
        [ApiParameter(
            Name = "screened_theatrically",
            Option = SerializationOption.ToLower,
            ParameterType = ParameterType.Query)]
        public virtual bool? IsScreenedTheatrically { get; set; }

        /// <summary>
        /// A comma separated list of production company ID's. Only include movies
        /// that have one of the ID's added as a production company.
        /// </summary>
        [ApiParameter(
            Name = "with_companies",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.Delimeter)]
        public virtual IEnumerable<int> WithCompanyIds { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            Delimeter = nameof(WithWatchProviderIdsDelimeter),
            Name = "with_watch_providers",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.Delimeter)]
        public virtual IEnumerable<int> WithWatchProviderIds { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameterIgnore]
        public virtual IEnumerable<int> WithWatchProviderIdsDelimeter { get; set; }

        /// <summary>
        /// An ISO 3166-1 code. Combine this filter with with_watch_providers
        /// in order to filter your results by a specific watch provider
        /// in a specific region.
        /// </summary>
        [ApiParameter(
            Name = "watch_region",
            ParameterType = ParameterType.Query)]
        public virtual string WithWatchProviderRegionCountryCode { get; set; }
    }
}