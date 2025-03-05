using Microsoft.AspNetCore.Mvc;
using Tumblr.Services.Interfaces;

namespace Tumblr.Controllers
{
    [ApiController]
    [Route("api/tumblr")]
    public class TumblrController : ControllerBase
    {
        private readonly ITumblrService _tumblrService;
        public TumblrController(ITumblrService tumblrService) => _tumblrService = tumblrService;

        [HttpGet("{blogName}/{start}/{end}")]
        public async Task<IActionResult> GetTumblrPosts(string blogName, int start, int end)
        {
            try
            {
                var data = await _tumblrService.GetTumblrDataAsync(blogName, start, end);
                return data is not null ? Ok(data) : NotFound("Invalid blog name");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }

}
