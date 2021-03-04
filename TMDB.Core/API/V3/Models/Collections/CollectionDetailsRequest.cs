using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Collections
{
    [ApiGetEndpoint("/collection/{collection_id}")]
    public class CollectionDetailsRequest : CollectionRequest
    {
    }
}