using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using portfolio_bff.Models.Linkedin;
using portfolio_bff.Services.Interfaces;

namespace portfolio_bff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkedinController : ControllerBase
    {
        private readonly IUserService<LinkedInUser> _userService;
        private readonly HttpClient _httpClient;

        public LinkedinController(IUserService<LinkedInUser> userService, IHttpClientFactory httpClientFactory)
        {
            _userService = userService;
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet("getUserById/{id}")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return Ok(user);
        }

        [HttpGet("getUserByUsername/{username}")]
        public async Task<IActionResult> GetUserByUsernameAsync(string username)
        {
            var user = await _userService.GetUserByUsernameAsync(username);
            return Ok(user);
        }
    }
}
