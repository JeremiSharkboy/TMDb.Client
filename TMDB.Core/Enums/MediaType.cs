using System.ComponentModel;

namespace TMDB.Core.Enums
{
    public enum MediaType
    {
        All = 0,
        [Description("movie")]
        Movie,
        [Description("tv")]
        TV,
        [Description("person")]
        Person
    }
}