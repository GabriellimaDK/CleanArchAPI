using DinnerHosting.Application.Services.Authentication;
using DinnerHosting.Contracts.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DinnerHostingCleanArch.Api.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(request.FirstName,
                request.LastName,
                request.Email,
                request.Password);

            var authenticationResponse = new AuthenticationResponse(
                authResult.Id,
                authResult.FisrtName,
                authResult.LastName,
                authResult.Email,
                authResult.Token);

            return Ok(authenticationResponse);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(request.Email, request.Password);

            var authenticationResponse = new AuthenticationResponse(
                authResult.Id,
                authResult.FisrtName,
                authResult.LastName,
                authResult.Email,
                authResult.Token);

            return Ok(authenticationResponse);
        }
    }
}
