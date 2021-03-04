using System.Runtime.Serialization;

namespace TMDB.Core.Enums
{
    public enum VideoType
    {
        Trailer,
        Teaser,
        Clip,
        Featurette,

        [EnumMember(Value = "Opening Credits")]
        OpeningCredits,

        [EnumMember(Value = "Behind the Scenes")]
        BehindTheScenes,

        Bloopers,
        Recap
    }
}