﻿using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiParameter(
       ParameterType = ParameterType.Endpoint,
       Value = "/list/{list_id}/add_item")]
    public class ListRemoveMovieRequest : ListRequestBase
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public string SessionId { get; set; }

        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        [Required]
        public string ContentType { get; set; }

        [ApiParameter(
            Name = "media_id",
            ParameterType = ParameterType.JsonBody)]
        [Obsolete("// TODO: Validation needed, value must be 1 or more")]
        public int MediaId { get; set; }
    }
}