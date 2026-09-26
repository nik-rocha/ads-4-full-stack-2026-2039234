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
            new TaskItem(1, null, "Tarefa 1", "Descrição 1", DateTime.Now, ""),
            new TaskItem(2, null, "Tarefa 2", "Descrição 2", DateTime.Now, ""),
            new TaskItem(3, null, "Tarefa 3", "Descrição 3", DateTime.Now, "")
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

            if (!string.IsNullOrWhiteSpace(newTask.TaskStatus))
            {
                return BadRequest(new { message = "A tarefa deve ser criada sem status definido. O status é definido apenas no endpoint MudarStatus." });
            }

            newTask.TaskStatus = "";

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

        [HttpPut("Editar/{id}")]
        public IActionResult EditarTarefa(int id, TaskItem selectedTask)
        {
            var task = taskDB.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound(new { message = "Tarefa não encontrada." });
            }
            if ((selectedTask.TaskName != task.TaskName) && (task.TaskStatus == "INICADA"))
            {
                return BadRequest(new { message = "Não é permitido alterar o título da tarefa iniciada." });
            }

            if (selectedTask.Responsible.Id != task.Responsible.Id)
            {
                return BadRequest(new { message = "Não é permitido alterar o responsável pela tarefa." });
            }

            if (selectedTask.TaskStatus != task.TaskStatus)
            {
                return BadRequest(new { message = "Não é permitido alterar o status da tarefa nesta ação." });
            }

            task.TaskName = selectedTask.TaskName;
            task.TaskDescription = selectedTask.TaskDescription;
            task.TaskDate = selectedTask.TaskDate;
            return Ok(new { message = "Status da tarefa atualizado com sucesso." });
        }

        [HttpPut("MudarStatus/{id}")]
        public IActionResult MudarStatusTarefa(int id, TaskItem selectedTask)
        {
            var task = taskDB.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound(new { message = "Tarefa não encontrada." });
            }

            if (task.TaskStatus == "INICIADA")
            {
                task.TaskStatus = "FINALIZADA";
            }
            else
            {
                task.TaskStatus = "INICIADA";
            }

            return Ok(new { message = "Status da tarefa atualizado com sucesso." });
        }

        [HttpPut("AdicionarResponsavel/{id}")]
        public IActionResult MudarResponsavelTarefa(int id, TaskItem selectedTask)
        {
            var task = taskDB.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound(new { message = "Tarefa não encontrada." });
            }

            return Ok();
        }

        [HttpDelete("Cancelar/{id}")]
        public IActionResult CancelarTarefa(int id)
        {
            var task = taskDB.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound(new { message = "Tarefa não encontrada." });
            }

            if (task.TaskStatus == "INICIADA" || task.TaskStatus == "FINALIZADA")
            {
                return BadRequest(new { message = "Não é possível cancelar uma tarefa com um status definido." });
            }

            return Ok(new { message = "Tarefa cancelada com sucesso." });
        }
    }
}
