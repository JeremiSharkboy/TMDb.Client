using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Changes
{
    [ApiGetEndpoint("/movie/changes")]
    public class MovieChangeListRequest : ChangeListRequest
    {
    }
}