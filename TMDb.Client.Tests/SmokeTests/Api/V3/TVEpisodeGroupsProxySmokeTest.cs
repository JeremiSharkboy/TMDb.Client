using System.Linq;
using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.TVEpisodeGroups;
using TMDB.Core.Tests.TestConstants;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class TVEpisodeGroupsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)TV.GameOfThrones)]
        public async Task TVEpisodeGroupsSmokeTest(uint tvId)
        {
            var tvEpisodeGroups = await Client.TV.GetAsync(new Core.Api.V3.Models.TV.TVEpisodeGroupsRequest 
            { 
                TVId = tvId 
            });
            
            var response = await Client.TVEpisodeGroups.GetAsync(new TVEpisodeGroupsRequest
            { 
                Id = tvEpisodeGroups.Results.Single().Id 
            });

            Assert.IsType<TVEpisodeGroupsResponse>(response);
            Assert.True(response.Network != null);
            Assert.True(response.Groups.Any());
        }
    }
}