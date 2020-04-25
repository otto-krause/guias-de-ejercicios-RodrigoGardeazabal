using System.Collections.Generic;
namespace E4
{
    public class peliteca
    {
        List<pelicula> peliculas=new List<pelicula>();
        Program primer = new Program();
        public int pelis(string opcion,int otro,int opc)
        {
            string dato1,dato2,dato3,dato4;
            int i=0,cant=0,cantigene=0,hay=0;
            if(otro==1)
            {
                peliculas.Add(new pelicula("Pokemon: la película", "animacion", "Kunihiko Yuyama","1998"));
                peliculas.Add(new pelicula("Pokémon la película 2000", "animacion", "Kunihiko Yuyama","1999"));
                peliculas.Add(new pelicula("Los jovenes titanes: mision Tokio", "animacion", "Michael Chang","2007"));
                peliculas.Add(new pelicula("El planeta del tesoro", "animacion", "Ron Clements","2002"));
                peliculas.Add(new pelicula("Hercules", "animacion", "Ron Clements","1997"));
                peliculas.Add(new pelicula("Miss Peregrine y los niños peculiares", "fantasia", "Tim Burton","2016"));
                peliculas.Add(new pelicula("El extraño mundo de Jack", "animacion", "Tim Burton","1993"));
                peliculas.Add(new pelicula("Charlie y la fábrica de chocolate", "fantasia", "Tim Burton","2005"));
                peliculas.Add(new pelicula("Deadpool", "comedia", "Tim Miller","2016"));
                peliculas.Add(new pelicula("Mulan", "animacion", "Tony Bancroft","1998"));
                peliculas.Add(new pelicula("Invasor Zim y el poder del florpus", "comedia", "Jhonen Vasquez","2019"));
                otro=2;
            }
            if(opc==1)
            {
                foreach (var item in peliculas)
                {
                    dato1=peliculas[i].titulo();
                    dato2=peliculas[i].generos();
                    dato3=peliculas[i].direccion();
                    dato4=peliculas[i].fecha();
                    if(opcion==peliculas[i].titulo())
                    {
                        hay++;
                        primer.imprimirt(dato1,dato2,dato3,dato4);
                    }
                    if(opcion==peliculas[i].generos())
                    {
                        hay++;
                        primer.imprimirg(dato1,dato2,dato3,dato4);
                    }
                    if(opcion==peliculas[i].direccion())
                    {
                        hay++;
                        primer.imprimird(dato1,dato2,dato3,dato4);
                    }
                    if(opcion==peliculas[i].fecha())
                    {
                        hay++;
                        primer.imprimirf(dato1,dato2,dato3,dato4);
                    }
                    i++;
                }
                primer.haypeli(hay);
            }
            if(opc==2)
            {
                foreach (var item in peliculas)
                {
                    cant++;
                }
                primer.cantidad(cant);
            }
            if(opc==3)
            {
                foreach (var item in peliculas)
                {
                    if(opcion==peliculas[i].generos())
                    {
                        cantigene++;
                    }
                    i++;
                }
                primer.cantidadgen(cantigene);
            }
            return otro;
        }
    }
}