using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PeopleTVCreditsCast : PeopleTVCreditsBasePerson
    {
        [JsonProperty("character")]
        public virtual string Character { get; set; }
    }
}