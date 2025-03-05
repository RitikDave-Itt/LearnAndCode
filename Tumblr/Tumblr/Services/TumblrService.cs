using System.Text.Json;
using System.Text.RegularExpressions;
using Tumblr.Modal;
using Tumblr.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Tumblr.Services
{
    public class TumblrService : ITumblrService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiUrl;

        public TumblrService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _baseApiUrl = configuration["TumblrApi:BaseUrl"];
        }

        public async Task<TumblrBlogInfo> GetTumblrDataAsync(string blogName, int start, int end)
        {
            string apiUrl = string.Format(_baseApiUrl, blogName) + $"?type=photo&num={end - start + 1}&start={start - 1}";

            string response = await _httpClient.GetStringAsync(apiUrl);
            string jsonString = Regex.Replace(response, @"^var tumblr_api_read = ", "").TrimEnd(';');
            using JsonDocument doc = JsonDocument.Parse(jsonString);
            JsonElement root = doc.RootElement;

            if (!root.TryGetProperty("tumblelog", out JsonElement tumblelog) || !root.TryGetProperty("posts", out JsonElement posts))
                return null;

            var blogInfo = new TumblrBlogInfo
            {
                Title = tumblelog.GetProperty("title").GetString() ?? "N/A",
                Description = tumblelog.GetProperty("description").GetString() ?? "N/A",
                Name = tumblelog.GetProperty("name").GetString() ?? "N/A",
                TotalPosts = root.GetProperty("posts-total").GetInt32()
            };

            int postNumber = start;
            foreach (JsonElement post in posts.EnumerateArray())
            {
                if (post.TryGetProperty("photos", out JsonElement photos))
                {
                    var tumblrPost = new TumblrPost { PostNumber = postNumber };
                    foreach (JsonElement photo in photos.EnumerateArray())
                    {
                        if (photo.TryGetProperty("photo-url-1280", out JsonElement photoUrl))
                            tumblrPost.ImageUrls.Add(photoUrl.GetString());
                    }
                    blogInfo.Posts.Add(tumblrPost);
                    postNumber++;
                }
            }
            return blogInfo;
        }
    }
}
