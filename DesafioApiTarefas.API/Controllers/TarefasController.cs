using Microsoft.AspNetCore.Mvc;

namespace DesafioApiTarefas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        [HttpPost]
        public IActionResult CriarTarefa()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult ObterTarefas()
        {
            return Ok();
        }

        [HttpPut("{id}")]   
        public IActionResult AtualizarTarefa(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]    
        public IActionResult DeletarTarefa(int id)
        {
            return Ok();
        }
    }
}
