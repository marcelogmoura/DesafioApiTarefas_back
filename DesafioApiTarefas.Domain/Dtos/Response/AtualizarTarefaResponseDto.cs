using DesafioApiTarefas.Domain.Enums;

namespace DesafioApiTarefas.Domain.Dtos.Response
{
    public class AtualizarTarefaResponseDto
    {
        public int Id { get; private set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataCriacao { get; private set; }
        public DateTime? DataConclusao { get; set; }        
        public Status Status { get; set; }
    }
}
