namespace E4
{
    public class pelicula
    {
        string genero,nombre,director,año;
        public pelicula(string nombre, string genero, string director, string año)
        {
            this.nombre=nombre;
            this.genero=genero;
            this.director=director;
            this.año=año;
        }
        public string titulo()
        {
            return nombre;
        }
        public string generos()
        {
            return genero;
        }
        public string direccion()
        {
            return director;
        }
        public string fecha()
        {
            return año;
        }
    }
}