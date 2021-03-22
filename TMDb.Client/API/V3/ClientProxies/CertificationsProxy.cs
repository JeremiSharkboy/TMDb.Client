using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Certifications;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class CertificationsProxy : ApiProxy
    {
        public CertificationsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<MovieCertificationsResponse> GetAsync(MovieCertificationsRequest request) =>
            Client.SendAsync<MovieCertificationsResponse>(request);

        public virtual Task<TVCertificationsResponse> GetAsync(TVCertificationsRequest request) =>
            Client.SendAsync<TVCertificationsResponse>(request);
    }
}