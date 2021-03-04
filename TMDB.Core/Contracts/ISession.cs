using TMDB.Core.Attributes;

namespace TMDB.Core.Contracts
{
    public interface ISession
    {
        [ApiParameter(
           Name = "session_id",
           ParameterType = ParameterType.Query)]
        string SessionId { get; set; }
    }
}