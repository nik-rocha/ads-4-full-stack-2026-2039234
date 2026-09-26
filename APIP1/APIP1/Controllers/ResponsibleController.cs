using APIP1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIP1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResponsibleController : ControllerBase
    {
        public static List<Responsible> responsibleDB = new List<Responsible>()
        {
            new Responsible(1, "Marcos", "marcos@gmail.com", "Administrador", new DateTime(1986, 5, 15)),
            new Responsible(2, "Ana", "ana@gmail.com", "Usuário", new DateTime(1990, 8, 20))
        };

        [HttpPost("Criar")]
        public IActionResult Criar(Responsible newResponsible)
        {
            if (responsibleDB.Any(r => r.Id == newResponsible.Id))
            {
                return BadRequest(new { message = "O usuário já existe." });
            }

            if (responsibleDB.Any(r => r.Email.Equals(newResponsible.Email, StringComparison.OrdinalIgnoreCase)))
            {
                return BadRequest(new { message = "Não é possível criar um usuário com o mesmo e-mail." });
            }

            responsibleDB.Add(newResponsible);
            return Ok(new { message = "Responsável criado com sucesso." });
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            return Ok(responsibleDB);
        }

        [HttpDelete("Remover/{id}")]
        public IActionResult Remover(int id)
        {
            var responsavel = responsibleDB.FirstOrDefault(r => r.Id == id);

            if (responsavel == null)
            {
                return NotFound(new { message = "O responsável não foi encontrado." });
            }

            responsibleDB.Remove(responsavel);
            return Ok(new { message = "Responsável removido com sucesso." });
        }
    }
}
