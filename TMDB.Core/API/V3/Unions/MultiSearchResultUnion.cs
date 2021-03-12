using Newtonsoft.Json;
using System.Diagnostics;
using TMDB.Core.Enums;
using TMDB.Core.JsonConverters;

namespace TMDB.Core.Api.V3.Models.Search
{
    [DebuggerDisplay("{MediaType}")]
    [JsonConverter(typeof(MovieTVConverter))]
    public struct MultiSearchResultUnion
    {
        [JsonProperty("media_type")]
        public MediaType MediaType { get; set; }

        public MultiSearchMovieResult Movie;
        public MultiSearchTVResult TV;
        public MultiSearchPersonResult Person;

        public static implicit operator MultiSearchResultUnion(MultiSearchMovieResult movie) =>
            new MultiSearchResultUnion
            {
                Movie = movie
            };

        public static implicit operator MultiSearchResultUnion(MultiSearchTVResult tv) =>
            new MultiSearchResultUnion
            {
                TV = tv
            };

        public static implicit operator MultiSearchResultUnion(MultiSearchPersonResult person) =>
            new MultiSearchResultUnion
            {
                Person = person
            };
    }
}