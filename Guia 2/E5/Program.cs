using System;

namespace E5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string producto="Leche armonia";
            int cant=3;
            Supermercado super =new Supermercado(producto,cant);
            Console.WriteLine("las ganancias del dia fueron:"+super.ganancias());
        }
    }
}
