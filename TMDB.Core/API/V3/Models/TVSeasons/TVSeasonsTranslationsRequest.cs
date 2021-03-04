using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/translations")]
    public class TVSeasonsTranslationsRequest : TVSeasonsRequest
    {
    }
}