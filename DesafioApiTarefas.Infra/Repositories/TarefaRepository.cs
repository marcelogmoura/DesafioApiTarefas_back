using DesafioApiTarefas.Domain.Entities;
using DesafioApiTarefas.Domain.Interfaces.Repositories;
using DesafioApiTarefas.Infra.Contexts;

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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tarefa> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tarefa? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Put(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }
    }
}
