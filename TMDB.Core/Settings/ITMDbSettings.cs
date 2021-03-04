using System;

namespace TMDB.Core.Settings
{
    public interface ITMDbSettings
    {
        string ApiKey { get; }
        Uri BaseUrl { get; }
        TimeSpan Timeout { get; }
        string Version { get; }
    }
}