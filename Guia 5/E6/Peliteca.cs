using System.Collections.Generic;
using System.Linq;
using System;
namespace E6
{
    public class Peliteca
    {
        List<Pelicula> peliculas = new List<Pelicula>();
        public Peliteca()
        {
            peliculas.Add(new Pelicula("Pokemon: La película", "Animacion", "1998", "Kunihiko Yuyama"));
            peliculas.Add(new Pelicula("El planeta del tesoro", "Animacion", "2002", "Ron Clements"));
            peliculas.Add(new Pelicula("Miss Peregrine y los niños peculiares", "Fantasia", "2016", "Tim Burton"));
            peliculas.Add(new Pelicula("El extraño mundo de Jack", "Musical", "1993", "Henry Selick"));
            peliculas.Add(new Pelicula("Coraline y la puerta secreta", "Terror", "2009", "Henry Selick")); 
        }
        public List<string> Eleccion(string busqueda, string opcion)
        {
            List<string> descripcion = new List<string>();
            switch (opcion)
            {
                case "1":
                peliculas.Where(i => i.Nombre==busqueda).ToList().ForEach(i => descripcion.Add(i.Descripcion()));
                break;
                case "2":
                peliculas.Where(i => i.Genero==busqueda).ToList().ForEach(i => descripcion.Add(i.Descripcion()));
                break;
                case "3":
                peliculas.Where(i => i.Año==busqueda).ToList().ForEach(i => descripcion.Add(i.Descripcion()));
                break;
                case "4":
                peliculas.Where(i => i.Director==busqueda).ToList().ForEach(i => descripcion.Add(i.Descripcion()));
                break;
            }
            return descripcion;
        }
        public int TotalPelis()
        {
            return peliculas.Count;
        }
        public int CantidadDeGenerosDePeliculas(string busqueda)
        {
            return peliculas.Count(i => i.Genero == busqueda);
        } 
    }
}