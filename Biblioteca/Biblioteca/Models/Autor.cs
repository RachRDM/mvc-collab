using System.Collections.Generic;

namespace Biblioteca.Models
{
    public class Autor
    {
        public Autor()
        {
            Livros = new List<Livro>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}