using System;
using System.Linq;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> datos=new List<Persona>();
            datos.Add(new Persona(18,"Rodrigo","Gardeazabal"));
            datos.Add(new Persona(29,"Armando","Mendoza"));
            datos.Add(new Persona(12,"Juan","Mora"));
            datos.Add(new Persona(30,"Juan","Perez"));
            datos.Add(new Persona(42,"Beatriz","Pinzon"));
            datos.Add(new Persona(23,"Gerardo","Pérez"));
            Console.WriteLine("Personas mayores de edad:");
            datos.Where(datos => datos.Edad>=18 ).ToList().ForEach(datos => Console.WriteLine(datos.Nombre+" "+datos.Apellido));
            Console.WriteLine("Las personas llamadas Juan:");
            datos.Where(datos => datos.Nombre=="Juan" ).ToList().ForEach(datos => Console.WriteLine(datos.Nombre+" "+datos.Apellido));
            int cuantos=datos.Count(datos => datos.Apellido=="Pérez");
            Console.WriteLine("Hay "+cuantos+" Pérez");
        }
    }
}
