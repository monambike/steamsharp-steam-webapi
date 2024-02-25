﻿using Newtonsoft.Json;
using SteamSharp.Utils;

namespace Monambike.Core.Services
{
    /// <summary>
    /// A simple HTTP service for making GET requests and retrieving the response content.
    /// </summary>
    public class SteamHttpService()
    {
        /// <summary>
        /// Base address for making api requests.
        /// </summary>
        public Uri Address => new("https://api.steampowered.com/");

        /// <summary>
        /// HttpClient for making api requests.
        /// </summary>
        public HttpClient HttpClient => new() { BaseAddress = Address };

        public string Version => "v0001";

        /// <summary>
        /// Sends an asynchronous GET request to the specified URI and returns the response content as a string.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance to use for the request.</param>
        /// <param name="strRequest">The URI of the resource to request.</param>
        /// <returns>A Task representing the asynchronous operation. The result contains the response content as a string.</returns>
        public async Task<T> GetAsync<T>(string interfaceName, string methodName, string version, string query)
        {
            // Tries to make the request with the base address and the request for URI validation.
            Uri.TryCreate($"{HttpClient.BaseAddress}/{interfaceName}/{methodName}/{version}/{query}/", UriKind.Absolute, out Uri? request);

            // If current URI is valid, makes the requisition and returns the response.
            using HttpResponseMessage response = await HttpClient.GetAsync(request);

            // Assigning assynchronously the content response as string.
            var content = await response.Content.ReadAsStringAsync();

            // Deserializing object into the provided class.
            var deserializedObject = JsonConvert.DeserializeObject<T>(content);

            // Throws an exception if deserialized object is null.
            ArgumentNullException.ThrowIfNull(deserializedObject);

            // Returning deserialized object content response into the provided class.
            return deserializedObject;
        }

        public void GetTest<T>(string token, string? steamId, Language? language = null)
        {
            GetAsync()
        }
    }
}