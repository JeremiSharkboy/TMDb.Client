﻿using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Changes;

namespace TMDB.NET.Api.V3.ClientProxies
{
    public class ChangesProxy : ApiProxy
    {
        public ChangesProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<ChangeListResponse> GetAsync(MovieChangeListRequest request) =>
            Client.SendAsync<ChangeListResponse>(request);

        public virtual Task<ChangeListResponse> GetAsync(PersonChangeListRequest request) =>
            Client.SendAsync<ChangeListResponse>(request);

        public virtual Task<ChangeListResponse> GetAsync(TVChangeListRequest request) =>
            Client.SendAsync<ChangeListResponse>(request);
    }
}