namespace DesafioApiTarefas.Domain.Exceptions
{
    public class TarefaNaoEncontradaException : Exception
    {        
        public TarefaNaoEncontradaException()
            : base("Tarefa não encontrada.")
        {
        }

        // Construtor que aceita o ID da tarefa 
        public TarefaNaoEncontradaException(int id)
            : base($"Tarefa com ID {id} não encontrada.")  
        {
        }

        // Construtor para mensagem customizada
        public TarefaNaoEncontradaException(string message)
            : base(message)
        {
        }

        public TarefaNaoEncontradaException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}