using System.Collections.Generic;
namespace E3
{
    public abstract class Consola
    {
        protected List<juegos> juego;
        protected int puntos;

        protected Consola()
        {
            this.juego = new List<juegos>();
            this.puntos = 0;
        }
        public abstract void crear(string nombrejuego, string nombreconsola,int añojuego);        
        public abstract void jugar(int minutos);
        public abstract int revisarpuntaje();
        public abstract string elmasviejo();
        public abstract string elmasnuevo();
    }
}