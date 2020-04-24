using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom,pos,pai;
            int opcion=1,figu=0,otro=1;
            Album elmundi = new Album();
            do
            {
                Console.Write("Ingrese nombre del jugador: ");
                nom=Console.ReadLine();
                Console.Write("Ingrese posicion del jugador: ");
                pos=Console.ReadLine();
                Console.Write("Ingrese pais del jugador: ");
                pai=Console.ReadLine();
                Console.Write("Ingrese numero de figurita: ");
                figu=Int32.Parse(Console.ReadLine());
                otro=elmundi.fig(nom,pos,pai,figu,otro,opcion);
            }
            while(opcion==1);
        }
    }
}
