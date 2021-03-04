using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Trending;
using TMDB.Core.Api;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class TrendingProxy : ApiProxy
    {
        public TrendingProxy(TMDbClient client) : base(client) 
        {
        }

        public virtual Task<TrendingResponse> GetAsync(TrendingRequest request) =>
            Client.SendAsync<TrendingResponse>(request);
    }
}