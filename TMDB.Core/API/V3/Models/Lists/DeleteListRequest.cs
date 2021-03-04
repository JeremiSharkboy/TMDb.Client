using System.ComponentModel.DataAnnotations;
using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Lists
{
    [ApiDeleteEndpoint("/list/{list_id}")]
    public class DeleteListRequest : ListRequestBase
    {
        [ApiParameter(
           Name = "session_id",
           ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }
    }
}