using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Collections
{
    [ApiGetEndpoint("/collection/{collection_id}/images")]
    public class CollectionImagesRequest : CollectionRequest
    {
    }
}