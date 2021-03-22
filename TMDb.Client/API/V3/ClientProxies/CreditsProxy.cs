using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Credits;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class CreditsProxy : ApiProxy
    {
        public CreditsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<CreditsResponse> GetAsync(CreditsRequest request) =>
            Client.SendAsync<CreditsResponse>(request);
    }
}