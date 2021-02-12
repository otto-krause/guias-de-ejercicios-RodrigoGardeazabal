using System;
using System.Linq;
using System.Collections.Generic;
namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>numero=new List<int>();
            Console.WriteLine("Ingrese numeros ilimitadamente y 0 para finalizar el ingreso");
            int numeros=0;
            int seguir = 1;
            while(seguir!=0)
            {
                numeros=Int32.Parse(Console.ReadLine());
                switch(numeros)
                {
                    case 0:
                        seguir = 0;
                        break;
                    default:
                        numero.Add(numeros);
                        break;
                }
            }
            Console.WriteLine("Los numeros ingresados fueron:");
            numero.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("\nDe ellos, la cantidad de impares es:");
            Console.WriteLine(numero.Count(x => x % 2 != 0));
            Console.WriteLine("\nEl primer par es:");
            Console.WriteLine(numero.First(x => x % 2 == 0));
            Console.WriteLine("\nLos numeros mayores a 50 son:");
            numero.Where(x => x > 50).ToList().ForEach(i => Console.WriteLine(i));
            Console.WriteLine("\nSiendo un total de:");
            Console.WriteLine(numero.Count(x => x > 50) + " numeros mayores a 50");
        }
    }
}