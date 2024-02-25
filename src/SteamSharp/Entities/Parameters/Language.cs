using SteamSharp.Utils;

namespace SteamSharp.Entities.Parameters
{
    public class Language(Utils.Language language) : BaseParameter("l", language.ToAPIName())
    {

    }
}
