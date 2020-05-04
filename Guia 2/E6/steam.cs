using System;
using System.Collections.Generic;
namespace E6
{
    public class steam
    {
        List<juego> jueguitos =new List<juego>();
        public void litjuego()
        {
            jueguitos.Add(new juego("counter", "accion", new List<juego.reseñas>()));
            jueguitos[0].reseñastotales.Add(new juego.reseñas("el mejor",5));
            jueguitos[0].reseñastotales.Add(new juego.reseñas("epicardo",5));
            jueguitos[0].reseñastotales.Add(new juego.reseñas("esta bueno pero me anda lento",4));
            jueguitos.Add(new juego("free fire", "accion", new List<juego.reseñas>()));
            jueguitos[1].reseñastotales.Add(new juego.reseñas("una verga",1));
            jueguitos[1].reseñastotales.Add(new juego.reseñas("meh",2));
            jueguitos[1].reseñastotales.Add(new juego.reseñas("aguante counter ahre",1));
            jueguitos.Add(new juego("minecraft", "sandbox", new List<juego.reseñas>()));
            jueguitos[2].reseñastotales.Add(new juego.reseñas("50/50",3));
            jueguitos[2].reseñastotales.Add(new juego.reseñas("F",2));
            jueguitos[2].reseñastotales.Add(new juego.reseñas(":v",4));
            jueguitos.Add(new juego("mago", "aventura", new List<juego.reseñas>()));
            jueguitos[3].reseñastotales.Add(new juego.reseñas("genial",5));
            jueguitos[3].reseñastotales.Add(new juego.reseñas("re piola",5));
            jueguitos[3].reseñastotales.Add(new juego.reseñas("me quede sin ideas ahre",5));
        }
        public void busquedagenero()
        {
            string genero;
            int i=0;
            Console.WriteLine("ingrese el genero del juego:");
            genero=Console.ReadLine();
            Console.WriteLine("Los juegos con ese genero son:");
            foreach (var item in jueguitos)
            {
                if(genero==jueguitos[i].gener())
                {
                    Console.WriteLine(""+jueguitos[i].nomb());
                }
                i++;
            }
        }
        public void busquedacalificacion()
        {
            int i=0;
            string calificacion;
            Console.WriteLine("ingrese la calificacion:");
            calificacion=Console.ReadLine();
            Console.WriteLine("Los juegos con la calificacion "+calificacion+" son:");
            foreach (var item in jueguitos)
            {    
                jueguitos[i].porcent(calificacion);
                i++;
            }
        }
    }
}