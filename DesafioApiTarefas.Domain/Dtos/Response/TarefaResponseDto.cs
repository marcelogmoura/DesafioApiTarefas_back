using DesafioApiTarefas.Domain.Enums;

namespace DesafioApiTarefas.Domain.Dtos.Response
{
    public class TarefaResponseDto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataCriacao { get; set; } = DateTime.Now;
        public Status Status { get; set; }
    }
}
