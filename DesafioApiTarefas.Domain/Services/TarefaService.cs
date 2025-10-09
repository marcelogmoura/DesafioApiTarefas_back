using DesafioApiTarefas.Domain.Dtos.Request;
using DesafioApiTarefas.Domain.Dtos.Response;
using DesafioApiTarefas.Domain.Interfaces.Services;

namespace DesafioApiTarefas.Domain.Services
{
    public class TarefaService : ITarefaService
    {
        public TarefaResponseDto? AtualizarTarefa(int id, TarefaRequestDto request)
        {
            throw new NotImplementedException();
        }

        public TarefaResponseDto CriarTarefa(TarefaRequestDto request)
        {
            throw new NotImplementedException();
        }

        public bool DeletarTarefa(int id)
        {
            throw new NotImplementedException();
        }

        public TarefaResponseDto? ObterTarefaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<TarefaResponseDto> ObterTodasTarefas()
        {
            throw new NotImplementedException();
        }
    }
}
