﻿using TMDB.Core.Attributes;
using TMDB.Core.Enums;

namespace TMDB.Core.Api.V3.Models.Find
{
    /// <summary>
    ///     	        Movies	TVShows TVSeasons TVEpisodes People
    ///     IMDb ID     	✓	     ✓	       ✗	      ✓      ✓
    ///     TVDB ID	        ✗	     ✓	       ✓	      ✓      ✗
    ///     Freebase MID*	✗	     ✓	       ✓	      ✓      ✓
    ///     Freebase ID*	✗	     ✓	       ✓	      ✓      ✓
    ///     TVRage ID*	    ✗	     ✓	       ✓	      ✓      ✓
    ///
    ///     *Defunct or no longer available as a service.
    /// </summary>
    [ApiGetEndpoint("/find/{external_id}")]
    public class FindByIdRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "external_id",
            ParameterType = ParameterType.Path)]
        public virtual string ExternalId { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        [ApiParameter(
            Name = "external_source",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.EnumDescription)]
        public virtual ExternalSource ExternalSource { get; set; }
    }
}