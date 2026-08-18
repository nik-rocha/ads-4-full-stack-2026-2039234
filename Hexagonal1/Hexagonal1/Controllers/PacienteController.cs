using Hexagonal1.DTOs;
using Hexagonal1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : ControllerBase
    {
        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar([FromBody] PacientSignUpRequest request)
        {
            var paciente = new Paciente
            {
                Id = 1,
                Nome = request.Nome,
                Idade = request.Idade,
                Senha = request.Senha
            };
            return Ok(paciente);
        }

        [HttpPut("Editar/{id}")]
        public IActionResult Editar(int id, [FromBody] PacientEditRequest request)
        {
            var pacienteEditado = new Paciente
            {
                Id = id,
                Nome = request.Nome,
                Idade = request.Idade
            };
            return Ok(pacienteEditado);
        }

        [HttpDelete("Arquivar/{id}")]
        public IActionResult Arquivar(int id)
        {
            Console.WriteLine("Paciente arquivado: \n");
            var pacienteDeletado = new Paciente
            {
                Id = id
            };
            return Ok(pacienteDeletado);
        }

        [HttpGet("BuscarHistorico/{id}")]
        public IActionResult BuscarHistorico(int id)
        {
            var pacienteEncontrado = new Paciente
            {
                Id = id
            };
            return Ok("Paciente encontrado:\nNome: " + pacienteEncontrado.Nome + "\nIdade: " + pacienteEncontrado.Idade + "\n");
        }
    }
}
