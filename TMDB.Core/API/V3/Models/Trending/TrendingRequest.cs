using System;
using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Trending
{
    [ApiGetEndpoint("/trending/{media_type}/{time_window}")]
    public class TrendingRequest : TMDbRequest
    {
        public TrendingRequest()
        {
            Page = 1;
        }

        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Range(1, 1000)]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "media_type",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual MediaType MediaType { get; set; }

        [ApiParameter(
            Name = "time_window",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual TimeWindow TimeWindow { get; set; }
    }
}