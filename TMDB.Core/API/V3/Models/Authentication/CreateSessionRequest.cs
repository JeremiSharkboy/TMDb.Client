using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Authentication
{
    [ApiPostEndpoint("/authentication/session/new")]
    public class CreateSessionRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "request_token",
            ParameterType = ParameterType.JsonBody)]
        public virtual string RequestToken { get; set; }
    }
}