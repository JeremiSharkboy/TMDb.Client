using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Discover;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class DiscoverProxy : ApiProxy
    {
        public DiscoverProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<DiscoverMovieResponse> GetAsync(DiscoverMovieRequest request) =>
            Client.SendAsync<DiscoverMovieResponse>(request);

        public virtual Task<DiscoverTVResponse> GetAsync(DiscoverTVRequest request) =>
            Client.SendAsync<DiscoverTVResponse>(request);
    }
}