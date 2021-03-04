using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TV
{
    [ApiGetEndpoint("/tv/{tv_id}/screened_theatrically")]
    public class TVScreenedTheatricallyRequest : TVBaseRequest
    {
    }
}