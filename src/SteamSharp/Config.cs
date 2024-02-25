namespace SteamSharp
{
    public class Config(string token)
    {
        /// <summary>
        /// Necessary to make requests to the API. You can create or check you token <a href="https://steamcommunity.com/dev/apikey">here</a>.
        /// </summary>
        public string Token => token;
    }
}
