using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Changes
{
    [ApiGetEndpoint("/person/changes")]
    public class PersonChangeListRequest : ChangeListRequest
    {
    }
}