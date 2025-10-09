using DesafioApiTarefas.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using DesafioApiTarefas.Domain.Entities; // Adicionar o using da entidade Tarefa

namespace DesafioApiTarefas.Infra.Contexts
{
    public class ApiContext : DbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public ApiContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDDesafioApiTarefas;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaMapping());
        }
    }
}