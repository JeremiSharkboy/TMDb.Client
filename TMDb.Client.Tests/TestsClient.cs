﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Configuration;
using Xunit;

namespace TMDb.Client.Tests
{
    public class TestsClient
    {
        public TestsClient() =>
            Client = new TMDbClient(TestsSettings.Instance.ApiKey, TestsSettings.Instance.Version);

        [Fact]
        public async Task TestApiKey()
        {
            var response = await Client.Configuration.GetConfigurationAsync();

            Assert.Same(typeof(ConfigurationResponse), response.GetType());
        }

        protected TMDbClient Client { get; private set; }
    }
}