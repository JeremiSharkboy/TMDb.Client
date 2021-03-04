using System;
using System.Linq;
using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Find;
using TMDB.Core.Enums;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class FindProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData("tt1285016", Language.AmericanEnglish, ExternalSource.IMDbId)]
        public async Task FindByIdSmokeTest(string externalId, string language, ExternalSource externalSource)
        {
            var response = await Client.Find.GetAsync(new FindByIdRequest
            {
                ExternalId = externalId,
                LanguageAbbreviation = language,
                ExternalSource = externalSource
            });

            Assert.IsType<FindByIdResponse>(response);
            Assert.True(response.MovieResults.Any());
        }
    }
}