using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;

namespace TMDB.NET.Configurations
{
    public interface IRestClientConfiguration
    {
        long MaxResponseContentBufferSize { get; }

        TimeSpan Timeout { get; }

        JsonSerializerSettings RequestSerializationSettings { get; }
        JsonSerializerSettings ResponseSerializationSettings { get; }
        MediaTypeWithQualityHeaderValue ApplicationJsonHeader { get; }
        MediaTypeWithQualityHeaderValue TextJsonHeader { get; }
    }
}