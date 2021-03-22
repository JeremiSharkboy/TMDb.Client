using System.Linq;
using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Genres;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class GenresProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData(Language.AmericanEnglish)]
        [InlineData(Language.CanadianFrench)]
        [InlineData(Language.Chinese)]
        [InlineData(Language.German)]
        [InlineData(Language.Italian)]
        public async Task MovieGenresSmokeTest(string language)
        {
            var response = await Client.Genres.GetAsync(new MovieGenresRequest
            {
                LanguageAbbreviation = language
            });

            Assert.IsType<MovieGenresResponse>(response);
            Assert.True(response.Genres.Any());
        }

        [Theory]
        [InlineData(Language.AmericanEnglish)]
        [InlineData(Language.CanadianFrench)]
        [InlineData(Language.Chinese)]
        [InlineData(Language.German)]
        [InlineData(Language.Italian)]
        public async Task TVGenresSmokeTest(string language)
        {
            var response = await Client.Genres.GetAsync(new GenresRequest
            {
                LanguageAbbreviation = language
            });

            Assert.IsType<GenresResponse>(response);
            Assert.True(response.Genres.Any());
        }
    }
}