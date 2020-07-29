using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinica clinica= new Clinica();
            string espe;
            Console.WriteLine("Ingrese la especialidad:");
            espe=Console.ReadLine();
            clinica.consulta(espe);
        }
    }
}
