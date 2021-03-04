using System.ComponentModel;

namespace TMDB.Core.Enums
{
    // TODO: Store enum/descrtion kvp in cached dictionary
    public enum Delimeter
    {
        [Description(",")]
        And,

        [Description("|")]
        Or
    }
}