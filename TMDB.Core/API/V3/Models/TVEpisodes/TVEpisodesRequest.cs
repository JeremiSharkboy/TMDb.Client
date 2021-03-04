using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDB.Core.Api.V3.Models.TVSeasons;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TVEpisodes
{
    public abstract class TVEpisodesRequest : TVSeasonsRequest
    {
        [ApiParameter(
            Name = "episode_number",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int EpisodeNumber { get; set; }
    }
}