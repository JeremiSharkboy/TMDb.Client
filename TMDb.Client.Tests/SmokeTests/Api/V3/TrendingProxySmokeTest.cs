﻿using System.Linq;
using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Trending;
using TMDB.Core.Enums;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class TrendingProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData(1, MediaType.Movie,  TimeWindow.Day)]
        [InlineData(1, MediaType.Person, TimeWindow.Day)]
        [InlineData(1, MediaType.TV,     TimeWindow.Day)]
        [InlineData(1, MediaType.Movie,  TimeWindow.Week)]
        [InlineData(1, MediaType.Person, TimeWindow.Week)]
        [InlineData(1, MediaType.TV,     TimeWindow.Week)]
        [InlineData(5, MediaType.Movie,  TimeWindow.Day)]
        [InlineData(5, MediaType.Person, TimeWindow.Day)]
        [InlineData(5, MediaType.TV,     TimeWindow.Day)]
        [InlineData(5, MediaType.Movie,  TimeWindow.Week)]
        [InlineData(5, MediaType.Person, TimeWindow.Week)]
        [InlineData(5, MediaType.TV,     TimeWindow.Week)]
        public async Task TrendingSmokeTest(int page, MediaType mediaType, TimeWindow timeWindow)
        {
            var response = await Client.Trending.GetAsync(new TrendingRequest
            {
                Page = page,
                MediaType = mediaType,
                TimeWindow = timeWindow
            });

            Assert.IsType<TrendingResponse>(response);
            Assert.True(response.Results.Any());
        }
    }
}