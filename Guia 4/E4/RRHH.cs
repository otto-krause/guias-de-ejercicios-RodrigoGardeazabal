using System;
namespace E4
{
    public class RRHH : Empleado
    {
        public override void depositar(string tipo)
        {
            if(tipo=="si")
            {
                cajabancaria+=5000;
            }
            cajabancaria+=5000;
        }

        public override void extraer(int extraccion)
        {
            if(cajabancaria-extraccion<0)
            {
                Console.WriteLine("no puede realizar la extraccion");
            }
            else
            {
                cajabancaria-=extraccion;
            }
        }
    }
}