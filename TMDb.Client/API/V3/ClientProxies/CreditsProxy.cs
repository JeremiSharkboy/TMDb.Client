﻿using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Credits;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class CreditsProxy : ApiProxy
    {
        public CreditsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<CreditsResponse> GetAsync(CreditsRequest request) =>
            Client.SendAsync<CreditsResponse>(request);
    }
}