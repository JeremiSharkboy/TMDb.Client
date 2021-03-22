using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Find;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class FindProxy : ApiProxy
    {
        public FindProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<FindByIdResponse> GetAsync(FindByIdRequest request) =>
            Client.SendAsync<FindByIdResponse>(request);
    }
}