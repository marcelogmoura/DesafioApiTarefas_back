using DesafioApiTarefas.Domain.Dtos.Request;
using DesafioApiTarefas.Domain.Dtos.Response;
using DesafioApiTarefas.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioApiTarefas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;
        public TarefasController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpPost]
        public IActionResult CriarTarefa(TarefaRequestDto request)
        {
            try
            {
                var response = _tarefaService.CriarTarefa(request);

                return StatusCode(201, response);

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ObterTarefas()
        {
            try
            {
                var response = _tarefaService.ObterTodasTarefas();
                return StatusCode(200, response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }

        }

        [HttpPut("{id}")]
        public IActionResult AtualizarTarefa(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarTarefa(int id)
        {
            try
            {
                _tarefaService.DeletarTarefa(id);
                return StatusCode(200, new { message = "Tarefa excluída"});
            }
            catch (ApplicationException ex)
            {
                return StatusCode(404, new { message = ex.Message });
            }

            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
