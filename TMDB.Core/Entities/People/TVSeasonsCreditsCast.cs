using Newtonsoft.Json;
using System.Diagnostics;

namespace TMDB.Core.Entities.People
{
    [DebuggerDisplay("{OriginalName}")]
    public class TVSeasonsCreditsCast : TVSeasonsCreditsCrew
    {
        [JsonProperty("order")]
        public virtual int? Order { get; set; }

        [JsonProperty("character")]
        public virtual string Character { get; set; }
    }
}