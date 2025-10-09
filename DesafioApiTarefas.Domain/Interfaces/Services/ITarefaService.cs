using DesafioApiTarefas.Domain.Dtos.Request;
using DesafioApiTarefas.Domain.Dtos.Response;

namespace DesafioApiTarefas.Domain.Interfaces.Services
{
    public interface ITarefaService
    {
        TarefaResponseDto CriarTarefa(TarefaRequestDto request);
        List<TarefaResponseDto> ObterTodasTarefas();
        TarefaResponseDto? ObterTarefaPorId(int id);
        TarefaResponseDto? AtualizarTarefa(int id, TarefaRequestDto request);
        bool DeletarTarefa(int id);


    }
}
