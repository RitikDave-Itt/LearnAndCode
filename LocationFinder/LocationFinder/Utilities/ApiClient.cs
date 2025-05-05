using System;
using System.Net.Http;
using System.Threading.Tasks;
using LocationFinder.Utilities.Exceptions;

namespace LocationFinder.Utilities
{
    public static class ApiClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<string> GetAsync(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new NullResponseException();
            }
        }
    }
}
