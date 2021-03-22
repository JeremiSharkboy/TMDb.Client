using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.GuestSessionRated;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class GuestSessionsProxy : ApiProxy
    {
        public GuestSessionsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<GuestSessionRatedMoviesResponse> GetAsync(GuestSessionRatedMoviesRequest request) =>
            Client.SendAsync<GuestSessionRatedMoviesResponse>(request);

        public virtual Task<GuestSessionRatedMoviesResponse> GetAsync(GuestSessionRatedTVRequest request) =>
            Client.SendAsync<GuestSessionRatedMoviesResponse>(request);

        public virtual Task<GuestSessionRatedTVEpisodesResponse> GetAsync(GuestSessionRatedTVEpisodesRequest request) =>
            Client.SendAsync<GuestSessionRatedTVEpisodesResponse>(request);
    }
}