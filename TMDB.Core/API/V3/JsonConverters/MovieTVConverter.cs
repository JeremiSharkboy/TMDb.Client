using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using TMDB.Core.Api.V3.Models.Search;
using TMDB.Core.Unions;

namespace TMDB.Core.JsonConverters
{
    public class MovieTVConverter : JsonConverter
    {
        private static readonly string _exceptionMessage;

        static MovieTVConverter() =>
            _exceptionMessage = $"Not able to marshal type {nameof(PopularPeopleKnownForMovieTVUnion)}";

        public override bool CanConvert(Type t) =>
            true;

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            var type = jObject.ToObject<SearchResult>();

            switch (type.MediaType)
            {
                case Enums.MediaType.Movie:
                    var movie = jObject.ToObject<MultiSearchMovieResult>();
                    return new MultiSearchResultUnion { Movie = movie, MediaType = type.MediaType };
                case Enums.MediaType.TV:
                    var tv = jObject.ToObject<MultiSearchTVResult>();
                    return new MultiSearchResultUnion { TV = tv, MediaType = type.MediaType };
                case Enums.MediaType.Person:
                    var pers = jObject.ToObject<MultiSearchPersonResult>();
                    return new MultiSearchResultUnion { Person = pers, MediaType = type.MediaType };
                default:
                    break;
            }

           
            //var dd = dob.TryParseObject(serializer, out MultiSearchMovieResult movieCrew);
            //var sfd = dob.TryParseObject(serializer, out MultiSearchTVResult tvCrew);
            //var fdf = reader.TryParseObject(serializer, out MultiSearchPersonResult person);
            //if (reader.TryParseObject(serializer, out MultiSearchMovieResult movieCrew))
            //{
            //    return new MultiSearchResultUnion { Movie = movieCrew };
            //}
            //if (reader.TryParseObject(serializer, out MultiSearchTVResult tvCrew))
            //{
            //    return new MultiSearchResultUnion { TV = tvCrew };
            //}
            //if (reader.TryParseObject(serializer, out MultiSearchPersonResult person))
            //{
            //    return new MultiSearchResultUnion { Person = person };
            //}

            throw new Exception(_exceptionMessage);
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (MultiSearchResultUnion)@object;

            if (value.Movie != null)
            {
                serializer.Serialize(writer, value.Movie);
            }
            else if (value.TV != null)
            {
                serializer.Serialize(writer, value.TV);
            }
            else if (value.Person != null)
            {
                serializer.Serialize(writer, value.Person);
            }

            //throw new Exception(_exceptionMessage);
        }

        private static PopularPeopleKnownForMovieTVConverter _instance;

        public static PopularPeopleKnownForMovieTVConverter Instance => _instance ??= new PopularPeopleKnownForMovieTVConverter();
    }
}