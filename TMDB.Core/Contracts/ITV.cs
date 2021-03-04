using System;
using System.Collections.Generic;
using TMDB.Core.Api.V3.Models.TV;
using TMDB.Core.Entities.Organizations;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Entities.Media
{
    public interface ITV : ITVMinified
    {
        bool? InProduction { get; set; }

        int? NumberOfEpisodes { get; set; }
        int? NumberOfSeasons { get; set; }

        string Status { get; set; }
        string Tagline { get; set; }
        string Type { get; set; }

        DateTime? LastAirDate { get; set; }

        Uri Homepage { get; set; }
        Episode LastEpisodeToAir { get; set; }
        Episode NextEpisodeToAir { get; set; }

        IEnumerable<int> EpisodeRunTime { get; set; }
        IEnumerable<string> Languages { get; set; }

        // TODO: Refactor this an entity?")]
        IEnumerable<TVDetailsCreatedBy> CreatedBy { get; set; }

        IEnumerable<Genre> Genres { get; set; }
        IEnumerable<Language> SpokenLanguages { get; set; }
        IEnumerable<Network> Networks { get; set; }
        IEnumerable<ProductionCompany> ProductionCompanies { get; set; }
        IEnumerable<ProductionCountry> ProductionCountries { get; set; }
        IEnumerable<Season> Seasons { get; set; }
    }
}