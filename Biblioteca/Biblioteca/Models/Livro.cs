using System.Collections.Generic;

namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Autor> Autores { get; set; }
    }
}