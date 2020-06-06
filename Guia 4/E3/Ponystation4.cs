using System.Collections.Generic;

namespace E3
{
    public class Ponystation4:Consola
    {
        public override void crear(string nombre, string Consola, int año)
        {
            juego.Add(new juegos(nombre,Consola,año));
            puntos+=29;
        }
        public override string elmasnuevo()
        {
            int viejo=0,i=0,j=0;
            foreach (var item in juego)
            {
                if(juego[i].años()>viejo)
                {
                    j=i;
                    viejo=juego[i].años();
                }
                i++;
            }
            return juego[j].nomb();
        }

        public override string elmasviejo()
        {
            int viejo=100000,i=0,j=0;
            foreach (var item in juego)
            {
                if(juego[i].años()<viejo)
                {
                    j=i;
                    viejo=juego[i].años();
                }
                i++;
            }
            return juego[j].nomb();
        }
        public override void jugar(int minutos)
        {
            puntos+=minutos*3;
        }

        public override int revisarpuntaje()
        {
            return puntos;
        }
    }
}