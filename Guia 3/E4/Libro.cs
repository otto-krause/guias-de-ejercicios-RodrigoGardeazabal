using System.Collections.Generic;
namespace E4
{
    public class Libro
    {
        private string titulo, autor;
        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public string titulos()
        {
            return titulo;
        }
        public string autores()
        {
            return autor;
        }
    }
}