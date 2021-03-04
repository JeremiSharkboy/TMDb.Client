using Newtonsoft.Json;

namespace TMDB.Core.Entities.People
{
    public class Person
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }
}