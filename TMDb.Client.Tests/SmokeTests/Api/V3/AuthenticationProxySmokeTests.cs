using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Authentication;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class AuthenticationProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task CreateGuestSessionSmokeTest()
        {
            var response = await Client.Authentication.GetAsync(new CreateGuestSessionRequest());

            Assert.IsType<CreateGuestSessionResponse>(response);
            Assert.True(response.IsSuccess);
            Assert.True(response.GuestSessionId is not null);
        }

        [Fact]
        public async Task CreateRequestTokenSmokeTest()
        {
            var response = await Client.Authentication.GetAsync(new CreateRequestTokenRequest());

            Assert.IsType<CreateRequestTokenResponse>(response);
            Assert.True(response.IsSuccess);
            Assert.True(response.RequestToken is not null);
        }

        // TODO: I don't believe this can be smoke tested...
        // It requires interaction with UI on TMDb's side of
        // a user's profile granting permission
        //[Fact]
        //public async Task CreateSessionSmokeTest()
        //{
        //    var response = await Client.Authentication.PostAsync(new CreateSessionRequest
        //    {
        //        RequestToken = (await Client.Authentication.GetAsync(new CreateRequestTokenRequest())).RequestToken
        //    });

        //    Assert.IsType<CreateSessionResponse>(response);
        //    Assert.True(response.IsSuccess);
        //    Assert.True(response.SessionId is not null);
        //}

        [Fact]
        public async Task CreateSessionWithLoginSmokeTest()
        {
            var response = await Client.Authentication.PostAsync(new CreateSessionWithLoginRequest
            {
                Username = _settings.Username,
                Password = _settings.Password,
                RequestToken = (await Client.Authentication.GetAsync(new CreateRequestTokenRequest())).RequestToken
            });

            Assert.IsType<CreateSessionWithLoginResponse>(response);
            Assert.True(response.IsSuccess);
            Assert.True(response.RequestToken is not null);
        }

        [Fact]
        public async Task DeleteSessionSmokeTest()
        {
            // Arrange
            var createSessionResponse = await Client.Authentication.PostAsync(new CreateSessionRequest
            {
                RequestToken = (await Client.Authentication.PostAsync(new CreateSessionWithLoginRequest
                {
                    Username = _settings.Username,
                    Password = _settings.Password,
                    RequestToken = (await Client.Authentication.GetAsync(new CreateRequestTokenRequest())).RequestToken
                })).RequestToken
            });

            // Act
            var response = await Client.Authentication.DeleteAsync(new DeleteSessionRequest 
            {
                SessionId = createSessionResponse.SessionId
            });

            // Assert
            Assert.IsType<DeleteSessionResponse>(response);
            Assert.True(response.IsSuccess);
        }
    }
}