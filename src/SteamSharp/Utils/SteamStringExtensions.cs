namespace SteamSharp.Utils
{
    /// <summary>
    /// Provides extension methods for string manipulation related to Steam API.
    /// </summary>
    public static class SteamStringExtensions
    {
        /// <summary>
        /// Turns the string into a Steamworks parameter if the string is not null, otherwise returns a empty string.
        /// </summary>
        /// <param name="str">The input string to which the parameter will be appended if input not null.</param>
        /// <returns>A new string with the appended Steamworks optional parameter if not null; otherwise, it returns an empty string.</returns>
        /// <remarks>
        /// If the input string is not null, it appends the parameter; otherwise, it returns an empty string.
        /// </remarks>
        public static string ToOptionalParameter(this string? str, string name) => str is not null ? $"&{name}={str}" : "";
    }
}
