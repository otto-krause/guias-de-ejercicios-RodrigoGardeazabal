using System;
using System.Collections.Generic;
namespace E6
{
    public class juego
    {
        string nombre,genero;        
        public List<reseñas> reseñastotales;
        public juego(string nombre,string genero, List<reseñas> reseñastotales)
        {
            this.nombre=nombre;
            this.genero=genero;
            this.reseñastotales=reseñastotales;
        }
        public class reseñas
        {
            public string reseña;
            public int cal;
            public reseñas(string reseña, int cal)
            {
                this.reseña=reseña;
                this.cal=cal;
            }
            public int calif()
            {
                return cal;
            }
        }
        public string gener()
        {
            return genero;
        }
        public string nomb()
        {
            return nombre;
        }
        public void porcent(string calificacion)
        {
            int i=0,cant=0;
            foreach (var item in reseñastotales)
            {
                cant+=reseñastotales[i].calif();
                i++;
            }
            if(calificacion=="alta")
            {
                if(cant/3==4||cant/3==5)
                {
                    Console.WriteLine(nomb());
                }
            }
            else
            {
                if(calificacion=="media")
                {
                    if(cant/3==3)
                    {
                        Console.WriteLine(nomb());
                    }
                }
                else
                {
                    if(calificacion=="baja")
                    {
                        if(cant/3==2||cant/3==1)
                        {
                            Console.WriteLine(nomb());
                        }
                    }
                    else
                    {
                        Console.WriteLine("ingrese una calificacion real");
                    }
                }
            }
        }
    }
}