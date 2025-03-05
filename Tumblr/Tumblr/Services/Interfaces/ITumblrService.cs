using Tumblr.Modal;

namespace Tumblr.Services.Interfaces
{
    public interface ITumblrService
    {
        Task<TumblrBlogInfo> GetTumblrDataAsync(string blogName, int start, int end);
    }
}
