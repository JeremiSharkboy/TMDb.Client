using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}/translations")]
    public class PeopleTranslationsRequest : PeopleBaseRequest
    {
    }
}