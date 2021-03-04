using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Authentication
{
    [ApiDeleteEndpoint("/authentication/session")]
    public class DeleteSessionRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.JsonBody)]
        public virtual string SessionId { get; set; }
    }
}