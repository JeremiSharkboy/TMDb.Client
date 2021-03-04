using Newtonsoft.Json;

namespace TMDB.Core.Entities.Organizations
{
    public class ProductionCompany : Company
    {
        [JsonProperty("origin_country")]
        public virtual string OriginCountry { get; set; }
    }
}