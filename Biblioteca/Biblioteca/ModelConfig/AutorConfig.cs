using Biblioteca.Models;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.ModelConfig
{
    public class AutorConfig : EntityTypeConfiguration<Autor>
    {
        public AutorConfig()
        {
            ToTable("Autores");

            HasKey(c => c.Id);

            Property(c => c.Nome)
                .HasMaxLength(80)
                .IsRequired();

            HasMany(c => c.Livros)
                .WithMany(c => c.Autores)
                .Map(c => c.ToTable("LivroAutor"));

        }
    }
}