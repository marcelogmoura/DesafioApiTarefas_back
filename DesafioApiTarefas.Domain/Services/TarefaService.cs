using DesafioApiTarefas.Domain.Dtos.Request;
using DesafioApiTarefas.Domain.Dtos.Response;
using DesafioApiTarefas.Domain.Entities;
using DesafioApiTarefas.Domain.Interfaces.Repositories;
using DesafioApiTarefas.Domain.Interfaces.Services;
using DesafioApiTarefas.Domain.Validations;
using DesafioApiTarefas.Domain.Exceptions;
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

        public TarefaResponseDto CriarTarefa(CriarTarefaRequestDto request)
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
                DataConclusao = tarefa.DataConclusao,
                Status = tarefa.Status
            };

            return response;
        }
        public TarefaResponseDto? AtualizarTarefa(int id, AtualizarTarefaRequestDto request)
        {
            var tarefa = _tarefaRepository.GetById(id);

            if(tarefa == null)
                throw new TarefaNaoEncontradaException(id);

            tarefa.Titulo = request.Titulo;
            tarefa.Descricao = request.Descricao;
            tarefa.Status = request.Status;
            tarefa.DataConclusao = request.DataConclusao;            

            var validationResult = _validator.Validate(tarefa);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }
            _tarefaRepository.Put(tarefa);

            return new TarefaResponseDto
            {
                Id = tarefa.Id,
                Titulo = tarefa.Titulo,
                Descricao = tarefa.Descricao,
                DataCriacao = tarefa.DataCriacao,
                DataConclusao = tarefa.DataConclusao,
                Status = tarefa.Status
            };
        }

        public void DeletarTarefa(int id)
        {

            var tarefa = _tarefaRepository.GetById(id);

            if (tarefa == null)
                throw new TarefaNaoEncontradaException(id);

            _tarefaRepository.Delete(tarefa);            

        }

        public TarefaResponseDto? ObterTarefaPorId(int id)
        {
            var tarefa = _tarefaRepository.GetById(id);

            if (tarefa == null)
                throw new TarefaNaoEncontradaException(id);

            return new TarefaResponseDto
            {
                Id = tarefa.Id,
                Titulo = tarefa.Titulo,
                Descricao = tarefa.Descricao,
                DataCriacao = tarefa.DataCriacao,
                DataConclusao = tarefa.DataConclusao,
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
                DataConclusao = tarefa.DataConclusao,
                Status = tarefa.Status
            }).ToList();
        }


    }
}
