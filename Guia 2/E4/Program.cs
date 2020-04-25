using System;

namespace E4
{
    class Program
    {
        int ge=1;
        static void Main(string[] args)
        {
            peliteca peli =new peliteca();
            string opcion="meh";
            int opc=0,otro=1,opcio=1;
            do
            {
                Console.WriteLine("\n1)Buscar una pelicula\n2)Saber cuantas peliculas hay en total\n3)saber cuantas peliculas de un genero hay");
                opc=Int32.Parse(Console.ReadLine());
                if(opc==1)
                {
                    Console.WriteLine("Ingrese genero, nombre, año o director para buscar la pelicula");
                    opcion=Console.ReadLine();
                    otro=peli.pelis(opcion,otro,opc);
                }
                else
                {
                    if(opc==2)
                    {
                        otro=peli.pelis(opcion,otro,opc);
                    }
                    else
                    {
                        if(opc==3)
                        {
                            Console.WriteLine("Ingrese el genero:");
                            opcion=Console.ReadLine();
                            otro=peli.pelis(opcion,otro,opc);
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una opcion correcta");
                        }
                    }
                }
                Console.WriteLine("Quiere realizar otra operacion\n1)Si\n2)No");
                opcio=Int32.Parse(Console.ReadLine());
            }
            while(opcio==1);
        }
        public void imprimirt(string dato1, string dato2, string dato3, string dato4)
        {
            Console.WriteLine("La pelicula con ese titulo es "+dato1+" del genero "+dato2+" del director "+dato3+" del año "+dato4);
        }
        public void imprimirg(string dato1, string dato2, string dato3, string dato4)
        {
            if(ge==1)
            {
                Console.WriteLine("Las peliculas con el genero "+dato2+" son:");
                ge=2;
            }
            Console.WriteLine(dato1);
        }
        public void imprimird(string dato1, string dato2, string dato3, string dato4)
        {
            if(ge==1)
            {
                Console.WriteLine("Las peliculas con el director "+dato3+" son:");
                ge=2;
            }
            Console.WriteLine(dato1);
        }
        public void imprimirf(string dato1, string dato2, string dato3, string dato4)
        {
            if(ge==1)
            {
                Console.WriteLine("Las peliculas del año "+dato4+" son:");
                ge=2;
            }
            Console.WriteLine(dato1);
        }
        public int cantidad(int cant)
        {
            Console.WriteLine("La cantidad total de peliculas es de: "+cant);
            return cant=0;
        }
        public void cantidadgen(int cantigene)
        {
            if(cantigene!=0)
            {
                Console.WriteLine("La cantidad de peliculas con ese genero es de: "+cantigene);
            }
            else
            {
                Console.WriteLine("No hay peliculas con ese genero");
            }
        }
        public int haypeli(int hay)
        {
            if(hay==0)
            {
                Console.WriteLine("Los datos no coinciden con ninguna pelicula que tengamos");
            }
            return hay=0;
        }
    }
}
