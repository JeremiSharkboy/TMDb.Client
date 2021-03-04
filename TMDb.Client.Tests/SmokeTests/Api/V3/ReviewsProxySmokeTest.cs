using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Reviews;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class ReviewsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData("58aa82f09251416f92006a3a")]
        public async Task ReviewsSmokeTest(string reviewId)
        {
            var response = await Client.Reviews.GetAsync(new ReviewsRequest
            {
                ReviewId = reviewId
            });

            Assert.IsType<ReviewsResponse>(response);
        }
    }
}