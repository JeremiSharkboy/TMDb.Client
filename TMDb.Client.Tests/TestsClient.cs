using System;
using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Account;
using TMDB.Core.Api.V3.Models.Authentication;
using TMDB.NET;

namespace TMDB.Core.Tests
{
    public class TestsClient : IDisposable
    {
        protected readonly TestsSettings _settings;

        public TestsClient()
        {
            _settings = TestsSettings.Instance;
            Client = new TMDbClient(_settings.ApiKey);
        }

        protected static AccountSmokeTestDeta SmokeTestAccountData { get; private set; }

        protected TMDbClient Client { get; private set; }

        public void Dispose()
        {
            if (Client is not null)
            {
                Client = null;
            }
        }

        protected async Task<AccountSmokeTestDeta> GetAccountDataAsync()
        {
            if (SmokeTestAccountData is null)
            {
                var accountDetails = await GetAccountDetailsAsync();
            }

            return SmokeTestAccountData ?? throw new NullReferenceException(nameof(SmokeTestAccountData));
        }

        protected async Task<GetAccountDetailsResponse> GetAccountDetailsAsync()
        {
            var createRequestTokenResponse = await Client.Authentication.GetAsync(new CreateRequestTokenRequest());

            var createSessionWithLoginResponse = await Client.Authentication.PostAsync(new CreateSessionWithLoginRequest
            {
                Username = _settings.Username,
                Password = _settings.Password,
                RequestToken = createRequestTokenResponse.RequestToken
            });

            var createSessionResponse = await Client.Authentication.PostAsync(new CreateSessionRequest
            {
                RequestToken = createSessionWithLoginResponse.RequestToken
            });

            var accountDetailsResponse = await Client.Account.GetAsync(new GetAccountDetailsRequest
            {
                SessionId = createSessionResponse.SessionId
            });

            if (SmokeTestAccountData is null)
            {
                SmokeTestAccountData = new AccountSmokeTestDeta
                {
                    AccountId = accountDetailsResponse.Id,
                    SessionId = createSessionResponse.SessionId
                };
            }

            return accountDetailsResponse;
        }

        protected class AccountSmokeTestDeta
        {
            public int AccountId { get; set; }
            public string SessionId { get; set; }
        }
    }
}