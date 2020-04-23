using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string especialid;
            Clinica enfermitos=new Clinica();
            Console.WriteLine("Las especialidades son:\nAngiologia\nDermatologia\nGinecologia\nOftalmologia\nTraumatologia\nOtorrinolaringologia\nIngrese con cual quiere un turno: ");
            especialid=(Console.ReadLine());
            enfermitos.especia(especialid);
        }
    }
}
