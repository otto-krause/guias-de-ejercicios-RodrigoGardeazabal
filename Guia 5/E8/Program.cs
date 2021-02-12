using System;
using System.Collections.Generic;
using System.Linq;
namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(6);
            numeros.Add(4);
            numeros.Add(1);
            numeros.Add(9);
            numeros.Add(3);
            numeros.Add(56);
            numeros.Add(13);
            numeros.Add(12);
            Matematica2 matematicas = new Matematica2(numeros);
            string opcion = "";
            while(opcion != "8")
            {
                Console.WriteLine("1)Saber los numeros primos de la lista\n2)Saber los numeros pares de la lista\n3)Mostrar la lista sin repetidos\n4)Sumatoria de los numeros\n5)Sumatoria de los numeros primos\n6)El numero mas grande\n7)El numero mas chico\n8)Salir");
                opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                        Console.WriteLine("Numeros Primos:\n");
                        matematicas.primos().ForEach(i => Console.WriteLine(i));
                        break;
                    case "2":
                        Console.WriteLine("\nNumeros Pares:\n");
                        matematicas.pares().ForEach(i => Console.WriteLine(i));
                        break;
                    case "3":
                        Console.WriteLine("\nLista sin repeticiones:\n");
                        matematicas.aplanar().ForEach(i => Console.WriteLine(i));
                        break;
                    case "4":
                        Console.WriteLine("\nSumatoria de los numeros:\n");
                        Console.WriteLine(matematicas.suma());
                        break;
                    case "5":
                        Console.WriteLine("\nSumatoria de los numeros primos:\n");
                        Console.WriteLine(matematicas.sumaPrimos());
                        break;
                    case "6":
                        Console.WriteLine("\nEl numero mas grande:\n");
                        Console.WriteLine(matematicas.mayor());
                        break;
                    case "7":
                        Console.WriteLine("\nEl numero mas chico:\n");
                        Console.WriteLine(matematicas.menor());
                        break;
                }
            }
        }
    }
}