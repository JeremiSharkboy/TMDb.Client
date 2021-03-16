using System.Linq;
using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Certifications;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class CertificationsProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task MovieCertificationsSmokeTest()
        {
            var response = await Client.Certifications.GetAsync(new MovieCertificationsRequest());

            Assert.IsType<MovieCertificationsResponse>(response);
            Assert.True(response.Certifications is not null);
            Assert.True(response.Certifications.US.Any());
        }

        [Fact]
        public async Task TVCertificationsSmokeTest()
        {
            var response = await Client.Certifications.GetAsync(new TVCertificationsRequest());

            Assert.IsType<TVCertificationsResponse>(response);
            Assert.True(response.Certifications is not null);
            Assert.True(response.Certifications.US.Any());
        }
    }
}