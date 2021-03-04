using System;

namespace TMDB.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ApiParameterIgnoreAttribute : Attribute
    {
    }
}