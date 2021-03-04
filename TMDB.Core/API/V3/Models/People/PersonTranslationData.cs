using Newtonsoft.Json;

namespace TMDB.Core.Api.V3.Models.People
{
    public class PersonTranslationData
    {
        [JsonProperty("biography")]
        public virtual string Biography { get; set; }
    }
}