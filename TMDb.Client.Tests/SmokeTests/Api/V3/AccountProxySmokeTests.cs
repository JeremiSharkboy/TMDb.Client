﻿using System;
using System.Linq;
using System.Threading.Tasks;
using TMDB.Core.Api.V3.Models.Account;
using TMDB.Core.Api.V3.Models.Authentication;
using TMDB.Core.Enums;
using TMDB.Core.Tests.TestConstants;
using Xunit;

namespace TMDB.Core.Tests.SmokeTests.Api.V3
{
    public class AccountProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task GetAccountDetailsSmokeTest()
        {
            // Arrange

            // Act
            var response = await GetAccountDetailsAsync();

            // Assert
            Assert.IsType<GetAccountDetailsResponse>(response);
            Assert.True(response.Id > 0);
        }

        [Fact]
        public async Task GetCreatedListsSmokeTest()
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.GetAsync(new GetCreatedListsRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                LanguageAbbreviation = Language.AmericanEnglish,
                Page = 1
            });

            // Assert
            Assert.IsType<GetCreatedListsResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Fact]
        public async Task GetFavoriteMoviesSmokeTest()
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.GetAsync(new GetFavoriteMoviesRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                LanguageAbbreviation = Language.AmericanEnglish,
                Page = 1
            });

            // Assert
            Assert.IsType<GetFavoriteMoviesResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Fact]
        public async Task GetFavoriteTVSmokeTest()
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.GetAsync(new GetFavoriteTVRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                LanguageAbbreviation = Language.AmericanEnglish,
                Page = 1
            });

            // Assert
            Assert.IsType<GetFavoriteTVResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Movie.Immortals, MediaType.Movie, false)]
        [InlineData((int)TV.GameOfThrones, MediaType.TV, false)]
        [InlineData((int)Movie.Immortals, MediaType.Movie, true)]
        [InlineData((int)TV.GameOfThrones, MediaType.TV, true)]
        public async Task MarkAsFavoriteSmokeTest(int mediaId, MediaType mediaType, bool favorite)
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.PostAsync(new MarkAsFavoriteRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                MediaId = mediaId,
                MediaType = mediaType,
                Favorite = favorite
            });

            // Assert
            Assert.IsType<MarkAsFavoriteResponse>(response);
            Assert.True(response.Success);
        }

        // TODO: add initial logic that rates a tv episode first
        [Fact]
        public async Task GetRatedMoviesSmokeTest()
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.GetAsync(new GetRatedMoviesRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                LanguageAbbreviation = Language.AmericanEnglish,
                Page = 1
            });

            // Assert
            Assert.IsType<GetRatedMoviesResponse>(response);
            Assert.True(response.Results.Any());
        }

        // TODO: add initial logic that rates a tv episode first
        [Fact]
        public async Task GetRatedTVSmokeTest()
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.GetAsync(new GetRatedTVRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                LanguageAbbreviation = Language.AmericanEnglish,
                Page = 1
            });

            // Assert
            Assert.IsType<GetRatedTVResponse>(response);
            Assert.True(response.Results.Any());
        }

        // TODO: add initial logic that rates a tv episode first
        [Fact]
        public async Task GetRatedTVEpisodesSmokeTest()
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.GetAsync(new GetRatedTVEpisodesRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                LanguageAbbreviation = Language.AmericanEnglish,
                Page = 1
            });

            // Assert
            Assert.IsType<GetRatedTVEpisodesResponse>(response);
            Assert.True(response.Results.Any());
        }

        // TODO: add initial logic that rates a movie to watchlist
        [Fact]
        public async Task GetMovieWatchlistSmokeTest()
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.GetAsync(new GetMovieWatchlistRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                LanguageAbbreviation = Language.AmericanEnglish,
                Page = 1
            });

            // Assert
            Assert.IsType<GetMovieWatchlistResponse>(response);
            Assert.True(response.Results.Any());
        }

        // TODO: add initial logic that rates a tv show to watchlist
        [Fact]
        public async Task GetTVWatchlistSmokeTest()
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.GetAsync(new GetTVWatchlistRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                LanguageAbbreviation = Language.AmericanEnglish,
                Page = 1
            });

            // Assert
            Assert.IsType<GetTVWatchlistResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Movie.Immortals, MediaType.Movie, true)]
        [InlineData((int)TV.ModernFamily, MediaType.TV, true)]
        [InlineData((int)Movie.Immortals, MediaType.Movie, false)]
        [InlineData((int)TV.ModernFamily, MediaType.TV, false)]
        public async Task AddToWatchlistSmokeTest(int mediaId, MediaType mediaType, bool watchlist)
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var accountId = accountData.AccountId;
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.Account.PostAsync(new AddToWatchlistRequest
            {
                AccountId = accountId,
                SessionId = sessionId,
                MediaId = mediaId,
                MediaType = mediaType,
                Watchlist = watchlist
            });

            // Assert
            Assert.IsType<AddToWatchlistResponse>(response);
            Assert.True(response.Success);
        }
    }
}