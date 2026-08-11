using Hexagonal1.DTOs;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost("Login")]
        public IActionResult Login([FromBody] DTOs.LoginRequest request)
        {
            Console.WriteLine("Id: " + request.Id);
            Console.WriteLine("Senha: " + request.Senha);
            return Ok("Fez Login, Uhuuuu");
        }
    }
}
