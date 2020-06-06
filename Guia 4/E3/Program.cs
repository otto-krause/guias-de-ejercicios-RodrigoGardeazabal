using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Consola pc= new PC();
            Consola ponystation4= new Ponystation4();
            Consola salada= new Ponystation4Salada();
            Consola caja= new CajaX();
            string nombre,opcion1,nombrejuego,nombreconsola;
            int opcion=1,añojuego,minutos;
            Console.Write("Ingrese el nombre del jugador: ");
            nombre=Console.ReadLine();
            Jugador jugador=new Jugador(nombre);
            Console.Write("Ingrese el nombre del juego: ");
            nombrejuego=Console.ReadLine();
            Console.Write("Ingrese el nombre de la consola del juego: ");
            nombreconsola=Console.ReadLine();
            Console.Write("Ingrese el año del juego: ");
            añojuego=Int32.Parse(Console.ReadLine());
            jugador.adquirirJuego(nombrejuego,nombreconsola,añojuego);
            do
            {
                Console.WriteLine("¿que quiere realizar?\n1)añadir un juego\n2)jugar con una consola\n3)ver puntaje\n4)ver el juego mas nuevo\n5)ver el juego mas viejo\n6)ver la consola mas usada\n7)salir");
                opcion1=Console.ReadLine();
                switch (opcion1)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del juego: ");
                        nombrejuego=Console.ReadLine();
                        Console.Write("Ingrese el nombre de la consola del juego: ");
                        nombreconsola=Console.ReadLine();
                        Console.Write("Ingrese el año del juego: ");
                        añojuego=Int32.Parse(Console.ReadLine());
                        jugador.adquirirJuego(nombrejuego,nombreconsola,añojuego);                
                        break;
                    case "2":
                        Console.Write("Ingrese el nombre de la consola con la que quiere jugar: ");
                        nombreconsola=Console.ReadLine();
                        Console.WriteLine("cuantas horas quiere jugar?");
                        minutos=Int32.Parse(Console.ReadLine());
                        jugador.jugar(minutos,nombreconsola);
                        break;
                    case "3":
                        Console.Write("Ingrese el nombre de la consola de la cual quiere ver sus puntos: ");
                        nombreconsola=Console.ReadLine();
                        Console.WriteLine("El puntaje de la consola es:"+jugador.revisar(nombreconsola));
                        break;
                    case "4":
                        Console.WriteLine("ingrese el nombre de la cual quiera ver el mas nuevo:");
                        nombreconsola=Console.ReadLine();
                        Console.WriteLine("El juego mas nuevo de "+nombreconsola+" es:"+jugador.Elmas(nombreconsola,opcion1));
                        break;
                    case "5":
                        Console.WriteLine("ingrese el nombre de la cual quiera ver el mas viejo:");
                        nombreconsola=Console.ReadLine();
                        Console.WriteLine("El juego mas viejo de "+nombreconsola+" es:"+jugador.Elmas(nombreconsola,opcion1));
                        break;
                    case "6":
                        Console.WriteLine("La consola mas usada es: "+jugador.masusada());
                        break;
                    case "7":
                        opcion=2;
                        break;
                    default:
                        Console.WriteLine("error");
                    break;
                }
            }
            while(opcion==1);
        }
    }
}
