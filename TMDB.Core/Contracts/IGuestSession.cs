using System;
using TMDB.Core.Attributes;

namespace TMDB.Core.Contracts
{
    public interface IGuestSession
    {
        [ApiParameter(
           Name = "guest_session_id",
           ParameterType = ParameterType.Query,
           Option = SerializationOption.NoHyphen)]
        Guid? GuestSessionId { get; set; }
    }
}