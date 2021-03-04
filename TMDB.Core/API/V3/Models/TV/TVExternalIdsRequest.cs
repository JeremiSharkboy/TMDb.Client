﻿using TMDB.Core.Attributes;

namespace TMDB.Core.Api.V3.Models.TV
{
    [ApiGetEndpoint("/tv/{tv_id}/external_ids")]
    public class TVExternalIdsRequest : TVBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}