using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shop.manoel.shared.Interfaces;
using shop.manoel.shared.Models.Request;

namespace shop.manoel.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IServiceAuth service;

        public AuthController(IServiceAuth service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserRequest sender)
        {
            var response = service.Login(sender);
            return Ok(response);
        }

    }
}
