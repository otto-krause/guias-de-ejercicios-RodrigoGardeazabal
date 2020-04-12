using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0,lado1,lado2,lado3;
            do
            {
                Console.WriteLine("ingresar los 3 lados del triangulo");
                lado1=Int32.Parse(Console.ReadLine());
                lado2=Int32.Parse(Console.ReadLine());
                lado3=Int32.Parse(Console.ReadLine());
            }while(opcion==1);
        }
    }
}