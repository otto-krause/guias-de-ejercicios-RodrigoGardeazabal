using System.Collections.Generic;
using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Serpensante pensante=new Robot();
            Humano humano=new Humano();
            int opcion=1;
            string opcion1,estudia,tema="";
            Console.WriteLine("ingrese una opcion");
            do
            {
                Console.WriteLine("Robot:\n1)Estudiar\n2)Pensar\nHumano:\n3)Estudiar\n4)Pensar\nCyborg:\n5)Estudiar\n6)Pensar\n7)Salir");
                opcion1=Console.ReadLine();
                switch (opcion1)
                {
                    case "1":
                        pensante=new Robot();
                        Console.WriteLine("ingrese lo que estudio");
                        estudia=Console.ReadLine();
                        pensante.estudiar(estudia);
                        break;
                    case "2":
                        pensante=new Robot();
                        Console.WriteLine("Puntos de inteligencia:"+pensante.pensar(tema));
                        break;
                    case "3":
                        pensante=new Humano();
                        Console.WriteLine("ingrese lo que estudio");
                        estudia=Console.ReadLine();
                        pensante.estudiar(estudia);
                        break;
                    case "4":
                        pensante=new Humano();
                        Console.WriteLine("Ingrese el tema a pensar:");
                        tema=Console.ReadLine();
                        Console.WriteLine("Puntos de inteligencia:"+pensante.pensar(tema));
                        break;
                    case "5":
                        pensante=new Cyborg();
                        Console.WriteLine("ingrese lo que estudio");
                        estudia=Console.ReadLine();
                        pensante.estudiar(estudia);
                        break;
                    case "6":
                        pensante=new Cyborg();
                        Console.WriteLine("Puntos de inteligencia:"+pensante.pensar(tema));
                        break;
                    case "7":
                        opcion=2;
                        break;
                    default:
                        Console.WriteLine("ingrese una opcion real");
                        break;
                }
            }
            while(opcion==1);
        }
    }
}
