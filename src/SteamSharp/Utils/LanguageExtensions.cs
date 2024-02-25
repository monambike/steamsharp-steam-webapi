namespace SteamSharp.Utils
{
    /// <summary>
    /// Provides extension methods for the <see cref="Language"/> enumerator.
    /// </summary>
    public static class LanguageExtensions
    {
        /// <summary>
        /// Converts a Language value to its corresponding name used in the Steamworks API. You can check the source <a href="https://www.ibabbleon.com/Steam-Supported-Languages-API-Codes.html">here</a>.
        /// </summary>
        /// <param name="language">The Language enum value.</param>
        /// <returns>The name used in the Steamworks API for the specified language.</returns>
        /// <exception cref="NotImplementedException">Throwed when the <paramref name="language"/> is not implemented.</exception>
        public static string ToAPIName(this Language language)
        {
            return language switch
            {
                Language.Arabic => "arabic",
                Language.Bulgarian => "bulgarian",
                Language.ChineseSimplified => "schinese",
                Language.ChineseTraditional => "tchinese",
                Language.Czech => "czech",
                Language.Danish => "danish",
                Language.Dutch => "dutch",
                Language.English => "english",
                Language.Finnish => "finnish",
                Language.French => "french",
                Language.German => "german",
                Language.Greek => "greek",
                Language.Hungarian => "hungarian",
                Language.Italian => "italian",
                Language.Japanese => "japanese",
                Language.Korean => "koreana",
                Language.Norwegian => "norwegian",
                Language.Polish => "polish",
                Language.PortugueseBrazil => "brazilian",
                Language.PortuguesePortugal => "portuguese",
                Language.Romanian => "romanian",
                Language.Russian => "russian",
                Language.SpanishLatinAmerica => "latam",
                Language.SpanishSpain => "spanish",
                Language.Swedish => "swedish",
                Language.Thai => "thai",
                Language.Turkish => "turkish",
                Language.Ukrainian => "ukrainian",
                Language.Vietnamese => "vietnamese",
                _ => throw new NotImplementedException()
            };
        }
    }
}
