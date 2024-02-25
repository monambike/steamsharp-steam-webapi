using SteamSharp.Utils;

namespace SteamSharp.Entities.Parameters
{
    public class Format(Utils.Format format) : BaseParameter("format", format.ToAPIName())
    {

    }
}
