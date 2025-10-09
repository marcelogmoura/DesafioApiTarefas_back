using DesafioApiTarefas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioApiTarefas.Infra.Mappings
{
    public class TarefaMapping : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TAREFAS");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(t => t.Titulo)
                .HasColumnName("TITULO")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(t => t.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(100);                

            builder.Property(t => t.DataCriacao)
                .HasColumnName("DATA_CRIACAO")
                .IsRequired();

            builder.Property(t => t.Status)
                .HasColumnName("STATUS")
                .HasConversion<string>()
                .IsRequired();
        }
    }
}
