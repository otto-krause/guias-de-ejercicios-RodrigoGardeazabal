using System;
using System.Collections.Generic;
using System.Linq;
namespace E11
{
    class Program
    {
        static void Main(string[] args)
        {
            Android sistemaOperativo = new Android();
            Console.WriteLine("\nLos juegos dentro de sistema son: ");
            sistemaOperativo.juegos().ForEach(app => Console.WriteLine(app.Nombre));
            Console.WriteLine("\nLas redes sociales dentro de sistema son: ");
            sistemaOperativo.redes().ForEach(app => Console.WriteLine(app.Nombre));
            Console.WriteLine("\nOtras aplicaciones dentro de sistema son: ");
            sistemaOperativo.otros().ForEach(app => Console.WriteLine(app.Nombre));
        }
    }
}