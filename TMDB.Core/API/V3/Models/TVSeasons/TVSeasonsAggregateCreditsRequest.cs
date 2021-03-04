using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/aggregate_credits")]
    public class TVSeasonsAggregateCreditsRequest : TVSeasonsRequest
    {
    }
}