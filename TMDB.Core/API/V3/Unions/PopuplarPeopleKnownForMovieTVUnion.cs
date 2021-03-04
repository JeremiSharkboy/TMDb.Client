using TMDB.Core.Api.V3.Models.People;

namespace TMDB.Core.Unions
{
    public struct PopularPeopleKnownForMovieTVUnion
    {
        public PersonKnownForMovie Movie;
        public PersonKnownForTV TV;

        public static implicit operator PopularPeopleKnownForMovieTVUnion(PersonKnownForMovie movie) =>
            new PopularPeopleKnownForMovieTVUnion
            {
                Movie = movie
            };

        public static implicit operator PopularPeopleKnownForMovieTVUnion(PersonKnownForTV tv) =>
            new PopularPeopleKnownForMovieTVUnion
            {
                TV = tv
            };
    }
}