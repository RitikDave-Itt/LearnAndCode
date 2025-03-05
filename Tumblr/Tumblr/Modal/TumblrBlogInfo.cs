namespace Tumblr.Modal
{
    public class TumblrBlogInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int TotalPosts { get; set; }
        public List<TumblrPost> Posts { get; set; } = new();
    }
}
