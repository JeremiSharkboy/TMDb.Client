using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.Search
{
    [ApiGetEndpoint("/search/keyword")]
    public class SearchKeywordsRequest : SearchRequest
    {
    }
}