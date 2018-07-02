using Biblioteca.Models;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.ModelConfig
{
    // Fluent Mapping
    public class LivroConfig : EntityTypeConfiguration<Livro>
    {
        public LivroConfig()
        {
            ToTable("Livros");

            HasKey(c => c.Id);

            Property(c => c.Titulo)
                .HasMaxLength(80)
                .IsRequired();

            HasMany(c => c.Autores);

            HasRequired(c => c.Categoria);


        }
    }
}