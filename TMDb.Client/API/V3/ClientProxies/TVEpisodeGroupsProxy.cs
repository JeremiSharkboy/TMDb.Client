using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.TVEpisodeGroups;
using TMDB.Core.Api;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class TVEpisodeGroupsProxy : ApiProxy
    {
        public TVEpisodeGroupsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<TVEpisodeGroupsResponse> GetAsync(TVEpisodeGroupsRequest request) =>
            Client.SendAsync<TVEpisodeGroupsResponse>(request);
    }
}