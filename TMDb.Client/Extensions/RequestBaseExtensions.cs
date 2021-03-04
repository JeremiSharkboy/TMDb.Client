using System.Linq;
using TMDB.Core.Api;
using TMDB.Core.Attributes;
using TMDB.NET.Models;

namespace TMDB.NET.Extensions
{
    public static class RequestBaseExtensions
    {
        public static ApiEndpoint GetApiEndpoint(this RequestBase request)
        {
            var endpoint = request.GetType()
                .GetCustomAttributes(inherit: true)
                .Single(x => x.GetType().IsAssignableFrom(typeof(ApiEndpointAttribute))
                          || x.GetType().IsSubclassOf(typeof(ApiEndpointAttribute)))
                .CastType<ApiEndpointAttribute>();

            return new ApiEndpoint
            {
                Path = endpoint.Path,
                HttpMethod = endpoint.HttpMethod
            };
        }
    }
}