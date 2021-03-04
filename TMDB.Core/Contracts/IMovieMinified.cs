﻿using System;
using System.Collections.Generic;

namespace TMDB.Core.Contracts
{
    public interface IMovieMinified
    {
        bool Adult { get; set; }
        bool Video { get; set; }

        double? Popularity { get; set; }
        double? VoteAverage { get; set; }

        uint Id { get; set; }
        int VoteCount { get; set; }

        string BackdropPath { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        // TODO: Rename property to OriginalLanguage")]
        string LanguageAbbreviation { get; set; }

        string OriginalTitle { get; set; }
        string Overview { get; set; }
        string PosterPath { get; set; }
        string Title { get; set; }

        DateTime? ReleaseDate { get; set; }

        // TODO: Create JSON Converter that will use Genres to fill data")]
        IEnumerable<int> GenreIds { get; set; }
    }
}