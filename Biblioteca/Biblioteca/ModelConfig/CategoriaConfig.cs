using Biblioteca.Models;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.ModelConfig
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            ToTable("Categorias");

            HasKey(c => c.Id);

            Property(c => c.Titulo)
                .HasMaxLength(30)
                .IsRequired();

            HasMany(c => c.Livros);

        }
    }
}