using System;
using System.Net.Http;
using TMDB.Core.Api;
using TMDB.NET.Configurations;

namespace TMDB.NET.Builders
{
    public interface IRequestBuilder
    {
        HttpRequestMessage BuildRequest(Uri baseAddress, RequestBase request, IRestClientConfiguration config);
    }
}