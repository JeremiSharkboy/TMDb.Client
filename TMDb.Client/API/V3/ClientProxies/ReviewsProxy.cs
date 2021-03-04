using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Reviews;
using TMDB.Core.Api;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class ReviewsProxy : ApiProxy
    {
        public ReviewsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<ReviewsResponse> GetAsync(ReviewsRequest request) =>
            Client.SendAsync<ReviewsResponse>(request);
    }
}