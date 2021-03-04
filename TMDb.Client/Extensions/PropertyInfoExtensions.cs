using System;
using System.Reflection;

namespace TMDB.NET.Extensions
{
    public static class PropertyInfoExtensions
    {
        public static bool HasAttribute<T>(this PropertyInfo propertyInfo) =>
            Attribute.IsDefined(propertyInfo, typeof(T));
    }
}