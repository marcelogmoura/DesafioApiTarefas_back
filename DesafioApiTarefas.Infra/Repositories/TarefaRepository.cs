using DesafioApiTarefas.Domain.Entities;
using DesafioApiTarefas.Domain.Interfaces.Repositories;
using DesafioApiTarefas.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DesafioApiTarefas.Infra.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly ApiContext _apiContext;
        public TarefaRepository(ApiContext apiContext)
        {
            _apiContext=apiContext;
        }

        public void Add(Tarefa tarefa)
        {
            _apiContext.Add(tarefa);
            _apiContext.SaveChanges();
        }

        public void Delete(Tarefa tarefa)
        {
            _apiContext.Remove(tarefa);
            _apiContext.SaveChanges();
        }
         
        public List<Tarefa> GetAll()
        {
            return _apiContext.Set<Tarefa>()
                              .OrderBy(t => t.Id)
                              .ToList();
        }

        public Tarefa? GetById(int id)
        {
            return _apiContext.Set<Tarefa>()
                              .SingleOrDefault(t => t.Id == id);
        }

        public void Put(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }
    }
}
