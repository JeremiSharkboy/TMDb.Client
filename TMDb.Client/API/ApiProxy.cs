﻿using System;

namespace TMDb.Client.API
{
    public abstract class ApiProxy
    {
        public ApiProxy(TMDbClient client) =>
            Client = client;

        protected TMDbClient Client { get; }

        protected Uri Serialize(string path, TMDbRequest request)
        {
            var settings = Client.Settings;
            request.ApiKey = settings.ApiKey;

            return new UriBuilder(Client.BaseAddress)
            {
                Path = PrependVersionToPath(settings.Version, path),
                Query = request.ToQueryString()
            }.Uri;
        }

        private string PrependVersionToPath(string version, string path) =>
            string.Format("/{0}/{1}", version, path.HasValue()
                ? path.TrimStart('/')
                : string.Empty);
    }
}