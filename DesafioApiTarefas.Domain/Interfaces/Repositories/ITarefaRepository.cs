using DesafioApiTarefas.Domain.Entities;

namespace DesafioApiTarefas.Domain.Interfaces.Repositories
{
    public interface ITarefaRepository
    {
        void Add(Tarefa tarefa);
        Tarefa? GetById(int id);
        List<Tarefa> GetAll();
        void Put(Tarefa tarefa);        
        void Delete(int id);
    }
}

/* async
 *      Task AddAsync(Tarefa tarefa);
        Task<Tarefa?> GetByIdAsync(int id); 
        Task<List<Tarefa>> GetAllAsync();
        Task UpdateAsync(Tarefa tarefa);
        Task DeleteAsync(int id);
 */