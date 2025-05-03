using BitBasket.Core.DTO;
using BitBasket.Core.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitBasket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request");
            }

            var authenticationResponse = await _userService.RegisterUser(request);

            if (authenticationResponse == null || !authenticationResponse.success)
            {
                return BadRequest(authenticationResponse);
            }
            else
            {
                return Ok(authenticationResponse);
            }

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request");
            }

            var authenticationResponse = await _userService.LoginUser(request);

            if (authenticationResponse == null || !authenticationResponse.success)
            {
                return Unauthorized(authenticationResponse);
            }
            else
            {
                return Ok(authenticationResponse);
            }

        }
    }
}
