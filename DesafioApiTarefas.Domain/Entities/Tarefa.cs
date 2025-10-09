using DesafioApiTarefas.Domain.Enums;

namespace DesafioApiTarefas.Domain.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataConclusao { get; set; }
        public Status Status { get; set; }

    }
}
