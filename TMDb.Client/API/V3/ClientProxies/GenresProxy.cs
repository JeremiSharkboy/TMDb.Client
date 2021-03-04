using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Genres;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class GenresProxy : ApiProxy
    {
        public GenresProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<MovieGenresResponse> GetAsync(MovieGenresRequest request) =>
            Client.SendAsync<MovieGenresResponse>(request);

        public virtual Task<GenresResponse> GetAsync(GenresRequest request) =>
            Client.SendAsync<GenresResponse>(request);
    }
}