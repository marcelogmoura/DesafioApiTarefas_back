using DesafioApiTarefas.Domain.Enums;

namespace DesafioApiTarefas.Domain.Dtos.Request
{
    public class AtualizarTarefaRequestDto
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataConclusao { get; set; }        
        public Status Status { get; set; }
    }
}
    