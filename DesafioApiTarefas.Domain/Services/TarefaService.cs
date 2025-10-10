using DesafioApiTarefas.Domain.Dtos.Request;
using DesafioApiTarefas.Domain.Dtos.Response;
using DesafioApiTarefas.Domain.Entities;
using DesafioApiTarefas.Domain.Interfaces.Repositories;
using DesafioApiTarefas.Domain.Interfaces.Services;
using DesafioApiTarefas.Domain.Validations;
using ValidationException = FluentValidation.ValidationException;

namespace DesafioApiTarefas.Domain.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly TarefaValidator _validator;
        public TarefaService(ITarefaRepository tarefaRepository, TarefaValidator validator)
        {
            _tarefaRepository=tarefaRepository;
            _validator=validator;
        }

        public TarefaResponseDto CriarTarefa(TarefaRequestDto request)
        {
            var tarefa = new Tarefa
            {                
                Titulo = request.Titulo,
                Descricao = request.Descricao,
                DataCriacao = DateTime.UtcNow,
                DataConclusao = null,        
                Status = Enums.Status.Pendente
            };
                        
            var validationResult = _validator.Validate(tarefa);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            _tarefaRepository.Add(tarefa);

            var response = new TarefaResponseDto
            {
                Id = tarefa.Id,
                Titulo = tarefa.Titulo,
                Descricao = tarefa.Descricao,
                DataCriacao = tarefa.DataCriacao,
                Status = tarefa.Status
            };

            return response;
        }
        public TarefaResponseDto? AtualizarTarefa(int id, TarefaRequestDto request)
        {
            throw new NotImplementedException();
        }

        public void DeletarTarefa(int id)
        {
            var tarefa = _tarefaRepository.GetById(id);

            if (tarefa == null)
                throw new KeyNotFoundException("Tarefa não encontrada.");

            _tarefaRepository.Delete(tarefa);            

        }

        public TarefaResponseDto? ObterTarefaPorId(int id)
        {
            var tarefa = _tarefaRepository.GetById(id);

            if (tarefa == null)
                throw new Exception("Tarefa não encontrada");

            return new TarefaResponseDto
            {
                Id = tarefa.Id,
                Titulo = tarefa.Titulo,
                Descricao = tarefa.Descricao,
                DataCriacao = tarefa.DataCriacao,                
                Status = tarefa.Status
            };
        }

        public List<TarefaResponseDto> ObterTodasTarefas()
        {
            var tarefas = _tarefaRepository.GetAll();

            return tarefas.Select(tarefa => new TarefaResponseDto
            {
                Id = tarefa.Id,
                Titulo = tarefa.Titulo,
                Descricao = tarefa.Descricao,
                DataCriacao = tarefa.DataCriacao,                
                Status = tarefa.Status
            }).ToList();
        }


    }
}
