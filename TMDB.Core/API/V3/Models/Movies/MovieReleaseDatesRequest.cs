﻿using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Movies
{
    /// <summary>
    /// Get the release date along with the certification for a movie.
    /// Release dates support different types:
    ///     1. Premiere
    ///     2. Theatrical(limited)
    ///     3. Theatrical
    ///     4. Digital
    ///     5. Physical
    ///     6. TV
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/release_dates")]
    public class MovieReleaseDatesRequest : MovieBaseRequest
    {
    }
}