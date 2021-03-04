using TMDB.Core.Api;
using TMDB.NET.Models;

namespace TMDB.NET.Builders
{
    public interface IApiParameterSerializer
    {
        ApiParameter SerializeRequestParameters(RequestBase request);
    }
}