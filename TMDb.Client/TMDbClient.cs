using System;
using TMDB.Core.Settings;
using TMDB.NET.Api.V3.ClientProxies;

namespace TMDB.NET
{
    public interface ITMDbClient
    {
        public AccountProxy Account { get; set; }
        public AuthenticationProxy Authentication { get; set; }
        public CertificationsProxy Certifications { get; set; }
        public ChangesProxy Changes { get; set; }
        public CollectionsProxy Collections { get; set; }
        public ConfigurationProxy Configuration { get; set; }
        public CreditsProxy Credits { get; set; }
        public DiscoverProxy Discover { get; set; }
        public ExportsProxy Exports { get; set; }
        public FindProxy Find { get; set; }
        public GenresProxy Genres { get; set; }
        public GuestSessionsProxy GuestSessions { get; set; }
        public KeywordsProxy Keywords { get; set; }
        public ListsProxy Lists { get; set; }
        public MoviesProxy Movies { get; set; }
        public NetworkProxy Network { get; set; }
        public PeopleProxy People { get; set; }
        public ReviewsProxy Reviews { get; set; }
        public SearchProxy Search { get; set; }
        public TrendingProxy Trending { get; set; }
        public TVEpisodeGroupsProxy TVEpisodeGroups { get; set; }
        public TVEpisodesProxy TVEpisodes { get; set; }
        public TVProxy TV { get; set; }
        public TVSeasonsProxy TVSeasons { get; set; }
    }

    public class TMDbClient : HttpClientWrapper, ITMDbClient
    {
        public TMDbClient(string apiKey) : this(DefaultTMDbSettings.CreateInstance(apiKey))
        {
        }

        // TODO: Implement lazy load pattern so each instance creation doesn't create every object instance for no reason")]
        public TMDbClient(ITMDbSettings settings) : base(settings.BaseUrl)
        {
            if (settings.ApiKey.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(settings.ApiKey));

            Settings = settings;
            Account = new AccountProxy(this);
            Authentication = new AuthenticationProxy(this);
            Certifications = new CertificationsProxy(this);
            Changes = new ChangesProxy(this);
            Collections = new CollectionsProxy(this);
            Configuration = new ConfigurationProxy(this);
            Credits = new CreditsProxy(this);
            Discover = new DiscoverProxy(this);
            Exports = new ExportsProxy(this);
            Find = new FindProxy(this);
            Genres = new GenresProxy(this);
            GuestSessions = new GuestSessionsProxy(this);
            Keywords = new KeywordsProxy(this);
            Lists = new ListsProxy(this);
            Movies = new MoviesProxy(this);
            Network = new NetworkProxy(this);
            People = new PeopleProxy(this);
            Reviews = new ReviewsProxy(this);
            Search = new SearchProxy(this);
            Trending = new TrendingProxy(this);
            TVEpisodeGroups = new TVEpisodeGroupsProxy(this);
            TVEpisodes = new TVEpisodesProxy(this);
            TV = new TVProxy(this);
            TVSeasons = new TVSeasonsProxy(this);
        }

        internal ITMDbSettings Settings { get; }

        public AccountProxy Account { get; set; }
        public AuthenticationProxy Authentication { get; set; }
        public CertificationsProxy Certifications { get; set; }
        public ChangesProxy Changes { get; set; }
        public CollectionsProxy Collections { get; set; }
        public ConfigurationProxy Configuration { get; set; }
        public CreditsProxy Credits { get; set; }
        public DiscoverProxy Discover { get; set; }
        public ExportsProxy Exports { get; set; }
        public FindProxy Find { get; set; }
        public GenresProxy Genres { get; set; }
        public GuestSessionsProxy GuestSessions { get; set; }
        public KeywordsProxy Keywords { get; set; }
        public ListsProxy Lists { get; set; }
        public MoviesProxy Movies { get; set; }
        public NetworkProxy Network { get; set; }
        public PeopleProxy People { get; set; }
        public ReviewsProxy Reviews { get; set; }
        public SearchProxy Search { get; set; }
        public TrendingProxy Trending { get; set; }
        public TVEpisodeGroupsProxy TVEpisodeGroups { get; set; }
        public TVEpisodesProxy TVEpisodes { get; set; }
        public TVProxy TV { get; set; }
        public TVSeasonsProxy TVSeasons { get; set; }
    }
}