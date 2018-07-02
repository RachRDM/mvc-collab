using Biblioteca.ModelConfig;
using Biblioteca.Models;
using System.Data.Entity;

namespace Biblioteca.Context
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
        : base("MinhaConnectionString")
        {

        }

        public DbSet<Autor> Autors { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livroes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new AutorConfig());
            modelBuilder.Configurations.Add(new LivroConfig());
            modelBuilder.Configurations.Add(new CategoriaConfig());

            base.OnModelCreating(modelBuilder);
        }


    }
}