using Newtonsoft.Json;
using TMDB.Core.Api.V3.Models.Changes;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TVEpisodes
{
    [ApiGetEndpoint("/tv/episode/{episode_id}/changes")]
    public class TVEpisodesChangesRequest : ChangeListRequest
    {
        [ApiParameter(
            Name = "episode_id",
            ParameterType = ParameterType.Path)]
        [JsonRequired]
        public virtual int EpisodeId { get; set; }
    }
}