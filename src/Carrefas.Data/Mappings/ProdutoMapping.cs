using Carrefas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carrefas.Data.Mappings
{
    //Fluent API
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(30)")
                .HasColumnName("Nome");

            builder.Property(p => p.Valor)
                .IsRequired()
                .HasPrecision(14, 2);

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(150)")
                .HasColumnName("Descricao");

            builder.Property(p => p.Ativo)
                .HasColumnName("Ativo");

            builder.ToTable("Produto");
        }
    }
}
