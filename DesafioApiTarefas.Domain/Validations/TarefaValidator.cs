using DesafioApiTarefas.Domain.Entities;
using FluentValidation;

namespace DesafioApiTarefas.Domain.Validations
{
    public class TarefaValidator : AbstractValidator<Tarefa>
    {
        public TarefaValidator()
        {
            RuleFor(t => t.Titulo)
                .NotEmpty()
                .WithMessage("O título é obrigatório.")
                .MaximumLength(100)
                .WithMessage("O título deve ter no máximo 100 caracteres.");

            RuleFor(t => t.DataConclusao)
                .GreaterThanOrEqualTo(t => t.DataCriacao.GetValueOrDefault())
                .WithMessage("A Data de Conclusão não pode ser anterior à Data de Criação.");
        }

    }
}

