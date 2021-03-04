﻿using System;
using System.Collections.Generic;
using TMDB.Core.Entities.Organizations;
using TMDB.Core.Entities.Things;

namespace TMDB.Core.Contracts
{
    public interface IMovie : IMovieMinified
    {
        int? Budget { get; set; }
        int? Revenue { get; set; }
        int? Runtime { get; set; }

        string IMDbId { get; set; }
        string Status { get; set; }
        string Tagline { get; set; }

        CollectionMinified Collection { get; set; }
        Uri Homepage { get; set; }

        IEnumerable<Genre> Genres { get; set; }
        IEnumerable<LanguageMinified> Languages { get; set; }
        IEnumerable<ProductionCompany> ProductionCompanies { get; set; }
        IEnumerable<ProductionCountry> ProductionCountries { get; set; }
    }
}