using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Networks
{
    [ApiGetEndpoint("/network/{network_id}/images")]
    public class NetworkImagesRequest : NetworksBaseRequest
    {
    }
}