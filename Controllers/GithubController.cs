using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using portfolio_bff.Models.Github;
using portfolio_bff.Services.Interfaces;

namespace portfolio_bff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        private readonly IUserService<GithubUser> _userService;
        private readonly HttpClient _httpClient;

        public GithubController(IUserService<GithubUser> userService, IHttpClientFactory httpClientFactory)
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
