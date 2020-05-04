using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion1=1,opcion=0;
            steam steam=new steam();
            steam.litjuego();
            do
            {
                Console.WriteLine("ingrese una opcion para buscar juegos\n1)genero\n2)calificacion");
                opcion=Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    steam.busquedagenero();
                }
                if(opcion==2)
                {
                    steam.busquedacalificacion();
                }
                Console.WriteLine("¿Quiere buscar otro juego?\n1)Si\n2)No");
                opcion1=Int32.Parse(Console.ReadLine());
            }while(opcion1==1);
        }
    }
}
