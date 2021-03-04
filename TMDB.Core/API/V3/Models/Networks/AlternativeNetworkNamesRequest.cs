using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Networks
{
    [ApiGetEndpoint("/network/{network_id}/alternative_names")]
    public class AlternativeNetworkNamesRequest : NetworksBaseRequest
    {
    }
}