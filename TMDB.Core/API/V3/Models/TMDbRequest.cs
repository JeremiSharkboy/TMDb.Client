﻿using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;
using TMDB.Core.Settings;

namespace TMDB.Core.Api.V3.Models
{
    public abstract class TMDbRequest : RequestBase
    {
        // TODO: *** Refactor out this reference directly to settings, apply it in another layer.
        public TMDbRequest() : this(DefaultTMDbSettings.Instance)
        {
        }

        // TODO: *** Refactor out this reference directly to settings, apply it in another layer.
        public TMDbRequest(ITMDbSettings settings)
        {
            // TODO: *** Refactor out this reference directly to settings, apply it in another layer.
            ApiKey = settings.ApiKey;

            // TODO: *** Refactor out this reference directly to settings, apply it in another layer.
            Version = settings.Version;
        }

        [ApiParameter(
            Name = "api_key",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string ApiKey { get; set; }

        [ApiParameter(
            Name = "version",
            ParameterType = ParameterType.Version)]
        [Required]
        public virtual string Version { get; set; }
    }
}