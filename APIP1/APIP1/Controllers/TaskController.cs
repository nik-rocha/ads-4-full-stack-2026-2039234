using APIP1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIP1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        public static List<TaskItem> taskDB = new List<TaskItem>()
        {

        };

        [HttpPost("Criar")]
        public IActionResult CriarTarefa(TaskItem newTask)
        {
            if (taskDB.Any(t => t.TaskName == newTask.TaskName))
            {
                return BadRequest(new {message = "Não é possível criar uma tarefa com o mesmo nome de outra tarefa."});
            }

            if (taskDB.Any(t => t.Id == newTask.Id))
            {
                return BadRequest(new { message = "Essa tarefa já existe." });
            }

            taskDB.Add(newTask);
            return Ok(new { message = "Tarefa criada com sucesso." });
        }

        [HttpGet("Procurar")]
        public IActionResult ProcurarTarefas(string? taskName, string? responsibleName, string? taskStatus)
        {
            var result = taskDB.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(taskName))
            {
                result = result.Where(t => t.TaskName.Contains(taskName, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(responsibleName))
            {
                result = result.Where(t => t.Responsible.Name.Contains(responsibleName, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(taskStatus))
            {
                result = result.Where(t => t.TaskStatus.Contains(taskStatus, StringComparison.OrdinalIgnoreCase));
            }

            var resultList = result.ToList();

            if (resultList.Count == 0)
            {
                return NotFound(new { message = "Nenhuma tarefa foi encontrada." });
            }

            return Ok(resultList);
        }
    }
}
