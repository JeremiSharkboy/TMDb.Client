using Newtonsoft.Json;
using TMDB.Core.Api.V3.Models.Changes;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/season/{season_id}/changes")]
    public class TVSeasonsChangesRequest : ChangeListRequest
    {
        [ApiParameter(
            Name = "season_id",
            ParameterType = ParameterType.Path)]
        [JsonRequired]
        public virtual int SeasonId { get; set; }
    }
}