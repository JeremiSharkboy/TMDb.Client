using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.People
{
    public abstract class PeopleBaseRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "person_id",
            ParameterType = ParameterType.Path)]
        public virtual uint PersonId { get; set; }
    }
}