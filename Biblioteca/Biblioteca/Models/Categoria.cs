using System.Collections.Generic;

namespace Biblioteca.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Livros = new List<Livro>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}