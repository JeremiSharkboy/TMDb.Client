﻿using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Collections
{
    [ApiGetEndpoint("/collection/{collection_id}")]
    public class CollectionDetailsRequest : CollectionRequest
    {
    }
}