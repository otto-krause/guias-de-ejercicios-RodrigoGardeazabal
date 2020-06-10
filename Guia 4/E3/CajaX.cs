using System.Collections.Generic;

namespace E3
{
    public class CajaX : Consola
    {
        public CajaX(): base()
        {
            this.juego=new List<juegos>();
        }
        public override void crear(string nombrejuego, string nombreconsola, int juegoaño)
        {
            var nuevo=new juegos(nombrejuego,nombreconsola,juegoaño);
            juego.Add(nuevo);
            puntos+=25;
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
            int viejo=10000,i=0,j=0;
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
            puntos+=minutos*4;
        }

        public override int revisarpuntaje()
        {
            return puntos;
        }
    }
}