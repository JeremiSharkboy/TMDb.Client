using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Lists
{
    public abstract class ListRequestBase : TMDbRequest
    {
        [ApiParameter(
            Name = "list_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int? ListId { get; set; }
    }
}