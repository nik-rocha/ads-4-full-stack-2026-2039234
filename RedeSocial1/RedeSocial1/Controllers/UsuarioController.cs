using Microsoft.AspNetCore.Mvc;
using RedeSocial1.Entities;

namespace RedeSocial1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        public static List<Usuario> usuarioDB = new List<Usuario>()
        {
            new Usuario(1, "Cezinha", 18, "cezuke2008", "lurdes123"),
            new Usuario(2, "SOL", 18, "sol123", "sozlinha"),
        };

        [HttpPost("Criar")]
        public IActionResult CriarUsuario(Usuario novoUsuario)
        {
            usuarioDB.Add(novoUsuario);
            return Created();
        }

        [HttpGet("listar")]
        public IActionResult ListarUsuarios()
        {
            return Ok(usuarioDB);
        }
    }
}
