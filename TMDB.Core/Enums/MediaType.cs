using System.ComponentModel;

namespace TMDB.Core.Enums
{
    public enum MediaType
    {
        Unknown,
        [Description("movie")]
        Movie,
        [Description("tv")]
        TV,
        [Description("person")]
        Person
    }
}