﻿namespace TMDB.Core.Api.V3.Models.Keywords
{
    public class KeywordDetailsResponse : TMDbResponse
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}