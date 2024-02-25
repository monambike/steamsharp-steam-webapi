namespace SteamSharp.Utils
{
    public static class FormatExtensions
    {
        /// <summary>
        /// Converts a Format value to its corresponding name used in the Steamworks API..
        /// </summary>
        /// <param name="format">The Format enum value.</param>
        /// <returns>The name used in the Steamworks API for the specified format.</returns>
        /// <exception cref="NotImplementedException">Throwed when the <paramref name="format"/> is not implemented.</exception>
        public static string ToAPIName(this Format format)
        {
            return format switch
            {
                Format.Json => "json",
                Format.Xml => "xml",
                Format.Vdf => "vdf",
                _ => throw new NotImplementedException()
            };
        }
    }
}
