using DesafioApiTarefas.Domain.Enums;

namespace DesafioApiTarefas.Domain.Dtos.Request
{
    public class TarefaRequestDto
    {       
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        //public DateTime? DataCriacao { get; set; } = DateTime.Now;
        public Status Status { get; set; }
    }
}
