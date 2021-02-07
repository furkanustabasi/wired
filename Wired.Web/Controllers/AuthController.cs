using Microsoft.AspNetCore.Mvc;
using System;
using Wired.Service.Abstract;
using Wired.Service.Models.Request;

namespace Wired.Web.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginRequestModel loginRequest)
        {
            try
            {
                var response = _authService.Login(loginRequest);

                return Ok(response);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

    }
}
