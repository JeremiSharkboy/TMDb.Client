using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Keywords;
using TMDB.Core.Api;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class KeywordsProxy : ApiProxy
    {
        public KeywordsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<KeywordDetailsResponse> GetAsync(KeywordDetailsRequest request) =>
            Client.SendAsync<KeywordDetailsResponse>(request);

        public virtual Task<KeywordMovieResponse> GetAsync(KeywordMovieRequest request) =>
            Client.SendAsync<KeywordMovieResponse>(request);
    }
}