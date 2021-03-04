using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Networks
{
    [ApiGetEndpoint("/network/{network_id}")]
    public class NetworkDetailsRequest : NetworksBaseRequest
    {
    }
}