using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}")]
    public class TVSeasonsDetailsRequest : TVSeasonsRequest
    {
        [ApiParameter(
            Name = "append_to_response",
            ParameterType = ParameterType.Query)]
        public virtual string AppendToResponse { get; set; }
    }
}