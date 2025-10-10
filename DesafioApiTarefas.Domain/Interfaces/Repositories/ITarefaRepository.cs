using DesafioApiTarefas.Domain.Entities;

namespace DesafioApiTarefas.Domain.Interfaces.Repositories
{
    public interface ITarefaRepository
    {
        void Add(Tarefa tarefa);
        Tarefa? GetById(int id);
        List<Tarefa> GetAll();
        void Put(Tarefa tarefa);        
        void Delete(Tarefa tarefa);
    }
}

