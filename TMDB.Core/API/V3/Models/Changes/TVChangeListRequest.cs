using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Changes
{
    [ApiGetEndpoint("/tv/changes")]
    public class TVChangeListRequest : ChangeListRequest
    {
    }
}