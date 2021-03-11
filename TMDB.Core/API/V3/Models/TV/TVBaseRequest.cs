using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TV
{
    public abstract class TVBaseRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "tv_id",
            ParameterType = ParameterType.Path)]
        public virtual uint TVId { get; set; }
    }
}