using System;
using System.Linq;
using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.People;
using TMDB.Core.Tests.TestConstants;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class PeopleProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleDetailsSmokeTest(uint personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleDetailsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.IsType<PeopleDetailsResponse>(response);
        }

        [Theory]
        [InlineData((int)Person.PeteDavidson,   1, "2021-01-11", "2021-01-23")]
        public async Task PeopleChangesSmokeTest(uint personId, int page, string startDate, string endDate)
        {
            var response = await Client.People.GetAsync(new PeopleChangesRequest
            {
                PersonId = personId,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            Assert.IsType<PeopleChangesResponse>(response);
            Assert.True(response.Changes.Any());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleMovieCreditsSmokeTest(uint personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleMovieCreditsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.IsType<PeopleMovieCreditsResponse>(response);
            Assert.True(response.Cast.Any());
            Assert.True(response.Crew.Any());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleTVCreditsSmokeTest(uint personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleTVCreditsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.IsType<PeopleTVCreditsResponse>(response);
            Assert.True(response.Cast.Any() || response.Crew.Any());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleCombinedCreditsSmokeTest(uint personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleCombinedCreditsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.IsType<PeopleCombinedCreditsResponse>(response);
            Assert.True(response.Cast.Any() || response.Crew.Any());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleExternalIdsSmokeTest(uint personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleExternalIdsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.IsType<PeopleExternalIdsResponse>(response);
        }

        [Theory]
        [InlineData((int)Person.AdamDevine   )]
        [InlineData((int)Person.AdamSandler  )]
        [InlineData((int)Person.AndersHolm   )]
        [InlineData((int)Person.BlakeAnderson)]
        [InlineData((int)Person.JoeRogan     )]
        [InlineData((int)Person.PeteDavidson )]
        [InlineData((int)Person.RobSchneider )]
        public async Task PeopleImagesSmokeTest(uint personId)
        {
            var response = await Client.People.GetAsync(new PeopleImagesRequest
            {
                PersonId = personId
            });

            Assert.IsType<PeopleImagesResponse>(response);
            Assert.True(response.Profiles.Any());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        public async Task PeopleTaggedImagesSmokeTest(uint personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleTaggedImagesRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.IsType<PeopleTaggedImagesResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine   )]
        [InlineData((int)Person.AdamSandler  )]
        [InlineData((int)Person.AndersHolm   )]
        [InlineData((int)Person.BlakeAnderson)]
        [InlineData((int)Person.JoeRogan     )]
        [InlineData((int)Person.PeteDavidson )]
        [InlineData((int)Person.RobSchneider )]
        public async Task PeopleTranslationsSmokeTest(uint personId)
        {
            var response = await Client.People.GetAsync(new PeopleTranslationsRequest
            {
                PersonId = personId
            });

            Assert.IsType<PeopleTranslationsResponse>(response);
            Assert.True(response.Translations.Any());
        }

        [Theory]
        [InlineData(Language.AmericanEnglish)]
        public async Task LatestPeopleSmokeTest(string language)
        {
            var response = await Client.People.GetAsync(new LatestPeopleRequest
            {
                LanguageAbbreviation = language
            });

            Assert.IsType<LatestPeopleResponse>(response);
        }

        [Theory]
        [InlineData(Language.AmericanEnglish)]
        public async Task PopularPeopleSmokeTest(string language)
        {
            var response = await Client.People.GetAsync(new PopularPeopleRequest
            {
                LanguageAbbreviation = language
            });

            Assert.IsType<PopularPeopleResponse>(response);
            Assert.True(response.Results.Any());
        }
    }
}