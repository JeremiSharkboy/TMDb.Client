using System;
using System.Net.Http;

namespace TMDB.NET.Validators
{
    public interface IStatusCodeValidator
    {
        void ValidateStatusCode(HttpResponseMessage response, Uri requestUri, int[] expectedStatusCodes);
    }
}