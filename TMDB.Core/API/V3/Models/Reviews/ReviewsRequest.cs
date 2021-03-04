using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Reviews
{
    [ApiGetEndpoint("/review/{review_id}")]
    public class ReviewsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "review_id",
            ParameterType = ParameterType.Path)]
        public virtual string ReviewId { get; set; }
    }
}