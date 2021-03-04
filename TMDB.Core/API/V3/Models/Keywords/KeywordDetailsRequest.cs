using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Keywords
{
    [ApiGetEndpoint("/keyword/{keyword_id}")]
    public class KeywordDetailsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "keyword_id",
            ParameterType = ParameterType.Path)]
        [Range(1, int.MaxValue)]
        [Required]
        public virtual int KeywordId { get; set; }
    }
}