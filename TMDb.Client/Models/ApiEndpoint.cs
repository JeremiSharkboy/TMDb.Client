using System.Net.Http;

namespace TMDB.NET.Models
{
    public class ApiEndpoint
    {
        public string Path { get; set; }
        public HttpMethod HttpMethod { get; set; }
    }
}