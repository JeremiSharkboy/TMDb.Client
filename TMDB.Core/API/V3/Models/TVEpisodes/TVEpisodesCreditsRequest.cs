using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TVEpisodes
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/credits")]
    public class TVEpisodesCreditsRequest : TVEpisodesRequest
    {
    }
}